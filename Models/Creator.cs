using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LNBServer.Models
{
    public class Creator
    {
        private   Name           _name;
        private   DateTime       _birthDate;
        protected List<LNSeries> _series;

        public List<LNSeries> Series { get => _series; set => _series = value; }
        public string RomanizedName { get => _name.Romanized; }
        public string JapaneseName { get => _name.Japanese; }

        public Creator(string japaneseName)
        {
            _name = new Name(japaneseName);
            _birthDate = DateTime.MinValue;
        }

        protected void addSeries(LNSeries series)
        {
            _series.Add(series);
        }
    }
}
