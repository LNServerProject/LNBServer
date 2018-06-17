using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LNBServer.Models
{
    public class LNSeries
    {
        public struct CachedStats
        {
            public decimal rating;

            public uint timesRated;
            public uint timesFavorited;
            public uint timesCompleted;
            public uint timesReading;
            public uint timesDesired;
            public uint timesDropped;
            public uint timesOnHold;
        }

        public enum Status
        {
            ongoing,
            hiatus,
            cancelled,
            completed
        }

        public uint              id;
        public List<LNVolume>    volumes;
        public Title             title;
        public LocalText         description;
        public string            website;
        public List<Author>      authors;
        public List<Artist>      artists;
        public List<ushort>      tags;
        public List<ushort>      spoilerTags;
        public List<byte>        genres;
        public List<LNLabel>     labels;
        public DateTime          started;
        public DateTime?         ended;
        public List<LNSeries>    spinoffs;
        public List<LNSeries>    prequels;
        public List<LNSeries>    sequels;
        public Status            status;
        public Image             cover;
        public CachedStats       cachedStats;
        public List<Review>      reviews;

        public List<LNPublisher> publishers
        {
            get
            {
                var publishers = new List<LNPublisher>();
                foreach (var label in labels)
                {
                    publishers.Add(label.publisher);
                }
                return publishers;
            }
        }
    }
}
