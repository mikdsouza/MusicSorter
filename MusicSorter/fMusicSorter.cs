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

                //Get all the files from that folder
                tbTest.Lines = getFiles(tbInputFolder.Text, new String[3] { "*.mp3", "*.m4a", "*.wma" }).ToArray();
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
    }

}
