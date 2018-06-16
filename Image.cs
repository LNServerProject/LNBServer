using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LNBServer
{
    public class Image
    {
        private string _link;
        private int _uniqueId;

        public Image()
        {
          
        }

        public void setInternalLink(string link)
        {
            _link = link;  
        }

    }
}
