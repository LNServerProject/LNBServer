using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LNBServer.Models
{
    public class LNVolume
    {
        public struct CachedStats
        {
            public decimal rating;

            public uint timesRated;
            public uint timesFavorited;

            public uint numCompleted;
            public uint numReading;
            public uint numOwned;   // "owned but not read"
            public uint numDesired; // "want to read"
        }
        public LNSeries     series;
        public Title        title;
        public LocalText    description;
        public ISBN         ISBN;
        public List<Author> authors;
        public List<Artist> artists;
        public ushort[]     tags;
        public ushort[]     spoilertags;
        public LNLabel      label;
        public ushort       pages;
        public byte         chapters;
        public BookType     bookType;
        public DateTime     releaseDate;
        public DateTime?    reprintDate;
        public Image        originalCover;
        public List<Image>  alternativeCovers;
        public string       amazonLink;
        public string       bookwalkerLink;
        public CachedStats  cachedStats;
        public List<Review> reviews;
    }
}
