using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LNBServer.Models
{
    public class LNPublisher
    {
        public uint          id;
        public Name          name;
        public string        website;
        public List<LNLabel> labels;
    }

    // Some LNs are serialized in magazines too. This shouldn't be much of an
    // issue, but if we need to manage them this is probably where to do so.
    public class LNLabel
    {
        public enum Type
        {
            lightNovel,
            lightLiterature,
            general
        }

        public enum Demographic
        {
            adult, 
            shoujo,
            josei,
            shounen, 
            seinen,
            BL,
            general
        }

        public uint        id;
        public bool        r18;
        public LNPublisher publisher;
        public string      name;
        public Type        type;
        public Demographic demographic;
    }
}
