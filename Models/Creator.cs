using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LNBServer.Models
{
    public class Creator
    {
        public int            Id { get; set; }
        public Name           Name { get; set; }
        public DateTime       BirthDate { get; set; }

        public string RomanizedName { get => Name.Romanized; }
        public string JapaneseName { get => Name.Japanese; }

        public Creator(string japaneseName)
        {
            Name = new Name(japaneseName);
            BirthDate = DateTime.MinValue;
        }
    }
}
