using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LNBServer.Models
{
    public enum TagType
    {
        General,        // (something that doesn't fall under one of these)
        Genre,          // e.g., Mystery
        CharacterTrait, // e.g., Yandere
        Language,       // e.g., English
    }

    public class Tag
    {
        [Key]
        public int     Id { get; set; }
        public TagType Type { get; set; }
        public string  Name { get; set; }
    }
}
