using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LNBServer
{
    public class Name
    {
        private string _japaneseName;
        private string _romanizedName;

        public string Japanese { get => _japaneseName; }
        public string Romanized { get => _romanizedName; }

        public Name(string japanese, string romanized = "")
        {
            _japaneseName = japanese;
            _romanizedName = romanized.Length != 0 ? romanized : LanguageServices.romanizeName(japanese);
        }
    }

    public class LanguageServices
    {
        public static string romanizeName(string japanese)
        {
            // FIXME: Implement
            return "";
        }
    }
}
