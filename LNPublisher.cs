using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LNBServer
{
    public class LNPublisher
    {
        public uint          id;
        public Name          name;
        public string        website;
        public List<LNLabel> labels;
    }


    ///Magazines exist...
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
    }
}
