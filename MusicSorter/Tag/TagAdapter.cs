using System;

namespace MusicSorter.Tag
{
    public interface TagAdapter
    {
        uint TrackNo
        {
            get;
            set;
        }

        String Title
        {
            get;
            set;
        }

        String Artist
        {
            get;
            set;
        }

        String Album
        {
            get;
            set;
        }

        String Filename
        {
            get;
        }

        void moveFile(string outputDir);
    }
}
