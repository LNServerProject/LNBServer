using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LNBServer
{
    public class Name
    {
        private readonly string _japaneseName;
        private readonly string _romanizedName;

        public string Japanese { get => _japaneseName; }
        public string Romanized { get => _romanizedName; }

        public Name(string japanese, string romanized = "")
        {
            _japaneseName  = japanese;
            _romanizedName = romanized.Length != 0 ? romanized : LanguageServices.romanizeName(japanese);
        }
    }

    public enum TextLanguageType
    {
        japanese,
        english
    }

    public struct LocalText
    {
        public Dictionary<TextLanguageType, string> entries;

        private string getTextForLanguageOrEmptyString(TextLanguageType key) => entries.ContainsKey(key) ? entries[key] : "";

        public string Japanese { get => getTextForLanguageOrEmptyString(TextLanguageType.japanese); }
        public string English { get => getTextForLanguageOrEmptyString(TextLanguageType.english); }
    }

    public class Title : Name
    {
        private readonly string _englishName;
        public  List<LocalText> alternateTitles;

        public string English { get => _englishName; }

        public Title(string japanese, string romanized = "", string english = "") : base(japanese, romanized)
        {
            _englishName = english;
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
