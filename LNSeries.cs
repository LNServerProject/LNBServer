using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LNBServer
{
    public class LNSeries
    {
        public enum BookStatus
        {
            ongoing,
            cancelled,
            completed
        }

        public  List<LNVolume> volumes;
        public  string         romanizedTitle;
        public  string         englishTitle;
        public  string[]       alternativeTitles;
        public  string         japaneseDescription;
        public  string         englishDescription;
        public  string         officialWebsite;
        public  List<string>   author;
        public  List<string>   artist;
        public  List<ushort>   tags;
        public  List<ushort>   spoilerTags;
        public  List<byte>     genres;
        public  List<string>   publisher;
        public  List<string>   publishingLabel;
        public  DateTime       started;
        public  DateTime       ended;
        public  List<LNSeries> spinoffs;
        public  List<LNSeries> prequels;
        public  List<LNSeries> sequels;
        public  BookStatus     status;
        public  Image          cover;
        public  decimal[]      overallRatings;
        public  uint           overallRated;
        public  uint           seriesRankingGlobal;
        public  uint           seriesPopularityGlobal;    
        public  uint           favorited;
        public  uint           read;
        public  uint           reading;
        public  uint           wantToRead;
        public  uint           dropped;
        public  uint           onHold;
        public  List<Review>   reviews;
    }
}
