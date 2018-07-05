using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LNBServer.Models
{
    public class LNVolume
    {
        /*
        public struct CachedStatsType
        {
            public decimal Rating { get; set; }

            public int     TimesRated { get; set; }
            public int     TimesFavorited { get; set; }

            public int     NumCompleted { get; set; }
            public int     NumReading { get; set; }
            public int     NumOwned { get; set; }   // "owned but not read"
            public int     NumDesired { get; set; } // "want to read"
        }
        */

        [Key]
        public int             Id { get; set; }
        public LNSeries        Series { get; set; }
        public Title           Title { get; set; }
        public LocalText       Description { get; set; }
        public ISBN            ISBN { get; set; }
        public List<Creator>   Authors { get; set; }
        public List<Creator>   Artists { get; set; }
        public List<Tag>       Tags { get; set; }
        public List<Tag>       SpoilerTags { get; set; }
        public LNLabel         Label { get; set; }
        public int             Pages { get; set; }
        public int             Chapters { get; set; }
        public BookType        BookType { get; set; }
        public DateTime        ReleaseDate { get; set; }
        public DateTime?       ReprintDate { get; set; }
        public Image           OriginalCover { get; set; }
        public List<Image>     AlternativeCovers { get; set; }
        public string          AmazonLink { get; set; }
        public string          BookwalkerLink { get; set; }
        public List<Review>    Reviews { get; set; }
        //public CachedStatsType CachedStats;
    }
}
