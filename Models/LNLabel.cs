using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LNBServer.Models
{
    public enum LabelType
    {
        LightNovel,
        LightLiterature,
        General
    }

    public enum LabelDemographic
    {
        Adult,
        Shoujo,
        Josei,
        Shounen,
        Seinen,
        BL,
        General
    }

    // Some LNs are serialized in magazines too. This shouldn't be much of an
    // issue, but if we need to manage them this is probably where to do so.
    public class LNLabel : DbEntity
    {
        public bool             R18 { get; set; }
        public LNPublisher      Publisher { get; set; }
        public string           Name { get; set; }
        public LabelType        Type { get; set; }
        public LabelDemographic Demographic { get; set; }
    }
}
