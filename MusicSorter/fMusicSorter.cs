using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Globalization;
using MusicSorter.Tag;
using System.Threading;

namespace MusicSorter
{
    public partial class fMusicSorter : Form
    {
        private TagAdapter currentFile;

        public fMusicSorter()
        {
            InitializeComponent();
            ThreadPool.SetMaxThreads(Environment.ProcessorCount, Environment.ProcessorCount);
        }

        private void bInputBrowse_Click(object sender, EventArgs e)
        {
            try
            {
                fbdInput.SelectedPath = tbInputFolder.Text;
            }
            catch (Exception exp)
            {
                Console.Out.WriteLineAsync(exp.Message);
                fbdInput.SelectedPath = fbdInput.RootFolder.ToString();
            }

            if (fbdInput.ShowDialog() == DialogResult.OK)
            {
                tbInputFolder.Text = fbdInput.SelectedPath;
                prepareFileList();
            }
        }

        private List<String> getFiles(String path, String[] extensions)
        {
            List<String> result = new List<string>();
            foreach (String ext in extensions)
            {
                result.AddRange(Directory.GetFiles(path, ext, SearchOption.AllDirectories));
            }

            return result;
        }

        private void lbFiles_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                currentFile = new TagLibAdapter(lbFiles.SelectedItem.ToString());
                tbLocation.Text = Path.GetDirectoryName(currentFile.Filename);
                tbFileName.Text = Path.GetFileName(currentFile.Filename);

                tbTrackNo.Text = currentFile.TrackNo.ToString();
                tbTitle.Text = currentFile.Title;
                tbArtist.Text = currentFile.Artist;
                tbAlbum.Text = currentFile.Album;
            }
            catch (TagLib.CorruptFileException)
            {
                MessageBox.Show(lbFiles.SelectedItem.ToString() + " is corrupt. Ignoring file");
                currentFile = null;
                tbTrackNo.Clear();
                tbTitle.Clear();
                tbArtist.Clear();
                tbAlbum.Clear();
                tbLocation.Clear();
                tbFileName.Clear();
            }
        }

        private void bProcess_Click(object sender, EventArgs e)
        {
            Cursor current = Cursor.Current;

            try
            {
                Cursor.Current = Cursors.WaitCursor;

                TextInfo textInfo = System.Threading.Thread.CurrentThread.CurrentCulture.TextInfo;

                String targetDir = Directory.CreateDirectory(tbInputFolder.Text + "\\output").FullName + "\\";
                foreach (String filename in lbFiles.Items)
                {
                    try
                    {
                        TagAdapter tg = new TagLibAdapter(filename);
                        tg.moveFile(targetDir);

                    }
                    catch (TagLib.CorruptFileException)
                    {
                        MessageBox.Show(filename + " is corrupt. Ignoring file");
                    }
                }

                prepareFileList();
                MessageBox.Show("Done!");
            }
            finally
            {
                Cursor.Current = current;
                current.Dispose();
            }
        }

        private void prepareFileList()
        {
            lbFiles.Items.Clear();
            //Get all the files from that folder
            lbFiles.Items.AddRange(getFiles(tbInputFolder.Text, new String[4] 
                    { "*.mp3", "*.m4a", "*.wma", "*.flac" }).ToArray());
        }

        private void bM4AtoMP3_Click(object sender, EventArgs e)
        {
            convertFormatToMP3(".m4a");
        }

        private void convertFormatToMP3(String format)
        {
            Cursor curCursor = Cursor.Current;
            try
            {
                Cursor.Current = Cursors.WaitCursor;
                List<String> files = new List<string>();

                foreach (String filename in lbFiles.Items)
                {
                    files.Add(filename);
                }

                files = files.Where(c => c.EndsWith(format)).ToList();

                foreach (string file in files)
                {
                    ThreadPool.QueueUserWorkItem(new WaitCallback(convertFile), file);
                    //convertFile(file);
                }
            }
            finally
            {
                Cursor.Current = curCursor;
                prepareFileList();
            }
        }

        private void convertFile(Object file)
        {
            String filename = (String)file;
            String outFile = Path.GetDirectoryName(filename) + "\\" +
                Path.GetFileNameWithoutExtension(filename) + ".mp3";
            String command = String.Format("-i \"{0}\" -id3v2_version 3 " +
                "-acodec libmp3lame -q:a 0 -y \"{1}\"", filename, outFile);
            try
            {
                System.Diagnostics.Process.Start("ffmpeg", command).WaitForExit();

                if (chkConvDelete.Checked)
                {
                    File.Delete(filename);
                }
            }
            catch (Exception exp)
            {
                MessageBox.Show("Could not convert " + filename + "\n" + exp.Message);
            }
        }

        private void bFLACtoMP3_Click(object sender, EventArgs e)
        {
            convertFormatToMP3(".flac");
        }

    }

}
