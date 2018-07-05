using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LNBServer.Models
{
    public class LNPublisher : DbEntity
    {
        public string        JapaneseName { get; set; }
        public string        RomajiName { get; set; }
        public string        Website { get; set; }
        public List<LNLabel> Labels { get; set; }
    }
}
