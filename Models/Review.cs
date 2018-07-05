using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LNBServer.Models
{
    public class Review : DbEntity
    {
        public string Body { get; set; }
        public uint Likes { get; set; }
        public uint Dislikes { get; set; }
    }
}
