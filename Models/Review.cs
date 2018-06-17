using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LNBServer.Models
{
    public class Review
    {
        private string _body;
        private uint _likes;
        private uint _dislikes;

        public Review(string body)
        {
            _body = body;
        }

        private uint Likes { get => _likes; set => _likes = value; }
        private uint Dislikes { get => _dislikes; set => _dislikes = value; }

        /*
        private void increaseLikes()
        {
            _likes++;
        }
        private void increaseDislikes()
        {
            _dislikes++;
        }
        */

    }
}
