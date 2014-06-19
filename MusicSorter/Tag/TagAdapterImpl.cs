using System;
using System.Globalization;
using System.IO;

namespace MusicSorter.Tag
{
    internal abstract class TagAdapterImpl : TagAdapter
    {
        static private readonly TextInfo textInfo = System.Threading.Thread.CurrentThread.CurrentCulture.TextInfo;

        protected bool changed = false;

        private uint trackNo;
        public uint TrackNo
        {
            get { return trackNo; }
            set { trackNo = value; changed = true; }
        }

        private string title;
        public string Title
        {
            get { return title; }
            set { title = value; changed = true; }
        }

        private string artist;
        public string Artist
        {
            get { return artist; }
            set { artist = value; changed = true; }
        }

        private string album;
        public string Album
        {
            get { return album; }
            set { album = value; changed = true; }
        }

        private string filename;
        public string Filename
        {
            get { return filename; }
        }

        public override string ToString()
        {
            return filename;
        }

        public TagAdapterImpl(string filename)
        {
            this.filename = filename;
            openFile(this.filename);
        }

        protected abstract void openFile(string filename);
        protected abstract void closeFile();
        protected abstract void saveFile();

        /// <summary>
        /// This function will create the new file name for the output
        /// </summary>
        /// <param name="outputDir">This name must containt a // at the end</param>
        /// <returns>A fully qualified file name and path</returns>
        private string getNewFilePath(string outputDir)
        {
            String newFileName = "", newFolderName = "";

            if (trackNo != 0)
                newFileName += String.Format("{0,-2:D2}", trackNo) + " - ";

            if (title != null)
                newFileName += textInfo.ToTitleCase(title);
            else
                newFileName += Path.GetFileNameWithoutExtension(filename);

            //newFileName += Path.GetExtension(filename);

            if (artist == null)
                newFolderName = "Unknown Artist\\";
            else
                newFolderName = textInfo.ToTitleCase(artist) + "\\";

            if (album == null)
                newFolderName += "Unknown Album\\";
            else
                newFolderName += textInfo.ToTitleCase(album) + "\\";

            //Correct the file names to not contain any : or &
            newFileName = correctString(newFileName);
            newFolderName = correctString(newFolderName);

            String finalPath = outputDir + newFolderName + newFileName;

            if (finalPath + Path.GetExtension(filename) != filename)
            {
                while (File.Exists(finalPath + Path.GetExtension(filename)))
                    finalPath += " (copy)";
            }

            return finalPath + Path.GetExtension(filename);
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

        /// <summary>
        /// This method will move the file to the new dir and open the file object on it
        /// </summary>
        /// <param name="outputDir">This is where the base of the file needs to move to</param>
        public void moveFile(string outputDir)
        {
            string path = getNewFilePath(outputDir);

            if (path == Filename)
            {
                return;
            }

            Directory.CreateDirectory(Path.GetDirectoryName(path));

            closeFile();
            File.Move(filename, path);
            filename = path;
            openFile(path);
        }
    }
}
