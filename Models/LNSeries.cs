using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LNBServer.Models
{
    public class LNSeries
    {
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

        [Key]
        public int               Id { get; set; }
        public List<LNVolume>    Volumes { get; set; }
        public Title             Title { get; set; }
        public LocalText         Description { get; set; }
        public string            Website { get; set; }
        public List<Author>      Authors { get; set; }
        public List<Artist>      Artists { get; set; }
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
