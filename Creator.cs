using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LNBServer
{
    public class Creator
    {
        protected string _japaneseName;
        protected DateTime birthDate;
        protected string _romanizedName;
        protected List<LNSeries> _series;

        


        public List<LNSeries> Series { get => _series; set => _series = value; }
        protected string RomanizedName { get => _romanizedName; set => _romanizedName = value; }
        protected string JapaneseName { get => _japaneseName; set => _japaneseName = value; }

        protected void addSeries(LNSeries series)
        {
            _series.Add(series);
        }

        

    }
}
