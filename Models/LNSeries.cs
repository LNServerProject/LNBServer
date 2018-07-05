using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace LNBServer.Models
{
    public class LNSeries : DbEntity
    {
        private static readonly string delimiter = "[:__:]";
        /*
        public struct CachedStatsType
        {
            public decimal Rating;

            public int     TimesRated;
            public int     TimesFavorited;
            public int     TimesCompleted;
            public int     TimesReading;
            public int     TimesDesired;
            public int     TimesDropped;
            public int     TimesOnHold;
        }
        */

        public enum StatusType
        {
            Ongoing,
            Hiatus,
            Cancelled,
            Completed
        }

        private string _associatedTitles;

        public List<LNVolume>    Volumes { get; set; }
        public string            JapaneseTitle { get; set; }
        public string            RomajiTitle { get; set; }
        public string            EnglishTitle { get; set; }
        [NotMapped]
        public string[] AssociatedTitles
        {
            get => _associatedTitles.Split(delimiter);
            set => _associatedTitles = string.Join("${delimiter}", value);
        }
        public string            EnglishDescription { get; set; }
        public string            JapaneseDescription { get; set; }
        public string            Website { get; set; }
        public List<Creator>     Authors { get; set; }
        public List<Creator>     Artists { get; set; }
        public List<Tag>         Tags { get; set; }
        public List<Tag>         SpoilerTags { get; set; }
        public List<LNLabel>     Labels { get; set; }
        public DateTime          Started { get; set; }
        public DateTime?         Ended { get; set; }
        public List<LNSeries>    Spinoffs { get; set; }
        public List<LNSeries>    Prequels { get; set; }
        public List<LNSeries>    Sequels { get; set; }
        public StatusType        Status { get; set; }
        public Image             Cover { get; set; }
        //public CachedStatsType   CachedStats { get; set; }
        public List<Review>      Reviews { get; set; }

        public List<LNPublisher> Publishers
        {
            get
            {
                var publishers = new List<LNPublisher>();
                foreach (var label in Labels)
                {
                    publishers.Add(label.Publisher);
                }
                return publishers;
            }
        }
    }
}
