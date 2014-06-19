using System;

namespace MusicSorter.Tag
{
    class TagLibAdapter: TagAdapterImpl
    {
        private TagLib.File tag;

        public TagLibAdapter(string filename): base(filename)
        {
            TrackNo = tag.Tag.Track;
            Title = tag.Tag.Title;
            Artist = tag.Tag.FirstPerformer;
            Album = tag.Tag.Album;
        }

        protected override void openFile(string filename)
        {
            tag = TagLib.File.Create(filename);
            changed = false;
        }

        protected override void closeFile()
        {
            tag.Dispose();
            changed = false;
        }

        protected override void saveFile()
        {
            if (changed)
            {
                tag.Tag.Track = TrackNo;
                tag.Tag.Title = Title;
                tag.Tag.Performers = new String[1] { Artist };
                tag.Tag.Album = Album;
                tag.Save();
                changed = false;
            }
        }

        public void Dispose()
        {
            closeFile();
        }
    }
}
