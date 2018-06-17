using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LNBServer.Models
{
    public class Author : Creator
    {
        public Author(string japaneseName) : base(japaneseName)
        {
        }
    }
}
