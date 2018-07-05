using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace LNBServer.Models
{
    public class Creator : DbEntity
    {
        public string   JapaneseName { get; set; }
        public string   RomanizedName { get; set; }

        public DateTime BirthDate { get; set; }

        public string   AboutDescription { get; set; }
    }
}
