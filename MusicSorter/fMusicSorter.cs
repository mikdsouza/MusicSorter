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

namespace MusicSorter
{
    public partial class fMusicSorter : Form
    {
        public fMusicSorter()
        {
            InitializeComponent();
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

                lbFiles.Items.Clear();
                //Get all the files from that folder
                lbFiles.Items.AddRange(getFiles(tbInputFolder.Text, new String[3] { "*.mp3", "*.m4a", "*.wma" }).ToArray());
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
            tbLocation.Text = Path.GetDirectoryName(lbFiles.SelectedItem.ToString());
            tbFileName.Text = Path.GetFileName(lbFiles.SelectedItem.ToString());

            TagLib.File f = TagLib.File.Create(lbFiles.SelectedItem.ToString());
            tbTrackNo.Text = f.Tag.Track.ToString();
            tbTitle.Text = f.Tag.Title;
            tbArtist.Text = f.Tag.FirstPerformer;
            tbAlbum.Text = f.Tag.Album;
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
                        String newFileName = "", newFolderName = "";

                        TagLib.Tag t = TagLib.File.Create(filename).Tag;

                        if (t.Track != 0)
                            newFileName += String.Format("{0,-2:D2}", t.Track) + " - ";

                        if (t.Title != null)
                            newFileName += textInfo.ToTitleCase(t.Title);
                        else
                            newFileName += Path.GetFileNameWithoutExtension(filename);

                        //newFileName += Path.GetExtension(filename);

                        if (t.FirstPerformer == null)
                            newFolderName = "Unknown Artist\\";
                        else
                            newFolderName = textInfo.ToTitleCase(t.FirstPerformer) + "\\";

                        if (t.Album == null)
                            newFolderName += "Unknown Album\\";
                        else
                            newFolderName += textInfo.ToTitleCase(t.Album) + "\\";

                        //Correct the file names to not contain any : or &
                        newFileName = correctString(newFileName);
                        newFolderName = correctString(newFolderName);

                        String finalPath = targetDir + newFolderName + newFileName;

                        if (finalPath + Path.GetExtension(filename) != filename)
                        {
                            while (File.Exists(finalPath + Path.GetExtension(filename)))
                                finalPath += " (copy)";
                        }

                        Directory.CreateDirectory(targetDir + newFolderName);
                        File.Move(filename, finalPath + Path.GetExtension(filename));

                    }
                    catch (TagLib.CorruptFileException)
                    {
                        MessageBox.Show(filename + " is corrupt. Ignoring file");
                    }
                }

                MessageBox.Show("Done!");
            }
            finally
            {
                Cursor.Current = current;
                current.Dispose();
            }
        }

        private String correctString(String input)
        {
            String result = input;

            result = result.Replace(":", "");
            result = result.Replace("&", "and");
            result = result.Replace("/", ",");
            result = result.Replace("?", "");
            result = result.Replace("*", "");

            return result;
        }

    }

}
