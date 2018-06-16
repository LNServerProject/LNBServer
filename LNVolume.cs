using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LNBServer
{
    public struct LNVolume
    {
        
        public LNSeries  LNseries;
        public string  romanizedTitle;
        public string  englishTitle;
        public string  japaneseDescription;
        public string  englishDescription;
        public ISBN  ISBN10;
        public string[]  author;
        public string[]  artist;
        public ushort[]  tags;
        public ushort[]  spoilertags;
        public string  publisher;
        public string  publishingLabel;
        public ushort  pages;
        public BookType  bookType;
      //  private uint  wordLength; // pages *  bookType
      //  private ushort  timeTakesToRead; // ( wordLength *  pages) / user.readingSpeed 
        public DateTime  releaseDate;
        public DateTime  reprintDate;
        public Image  originalCover;
        public Image[]  alternativeCovers;
        public string  amazonLink;
        public string  bookwalkerLink;
        public decimal[]  ratings;
        public uint  ratedBy;
        public uint  volumeRankingInSeries;
        public uint  volumePopularityInSeres;
        public uint  volumePopularityGlobal;
        public uint  volumeRankingGlobal;
        public uint  timesFavorited;
        public uint  read;
        public uint  ownButNotRead;
        public uint  wantToRead;
        public List<Review>  reviews;
        

    }
}
