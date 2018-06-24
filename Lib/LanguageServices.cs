using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
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

    public class LocalTextEntry
    {
        public int              Id { get; set; }
        public TextLanguageType Lang { get; set; }
        public string           Text { get; set; }
    }

    public class LocalText
    {
        public int                  Id { get; set; }
        public List<LocalTextEntry> Entries { get; set; }

        private string getTextForLanguage(TextLanguageType key)
        {
            foreach (var entry in Entries)
            {
                if (entry.Lang == key)
                {
                    return entry.Text;
                }
            }

            return "";
        }
        private void setTextForLanguage(TextLanguageType key, string text)
        {
            foreach(var entry in Entries)
            {
                if(entry.Lang == key)
                {
                    entry.Text = text;
                    return;
                }
            }

            Entries.Add(new LocalTextEntry { Lang = key, Text = text });
        }

        [NotMapped]
        public string Japanese { get => getTextForLanguage(TextLanguageType.japanese); set => setTextForLanguage(TextLanguageType.japanese, value); }
        [NotMapped]
        public string English { get => getTextForLanguage(TextLanguageType.english); set => setTextForLanguage(TextLanguageType.english, value); }
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
