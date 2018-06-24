using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LNBServer.Models
{
    public class Image
    {
        [Key]
        public int    Id;
        public string Link;
    }
}
