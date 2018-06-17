using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LNBServer.Models
{
    public class Artist : Creator
    {
        public Artist(string japaneseName) : base(japaneseName)
        {
        }
    }
}
