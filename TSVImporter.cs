using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace LNBServer
{
    public class TSVImporter : LNImporter
    {
        

        public void parse(string date, string label, string title, string author, string artist, string ISBN13, string page)
        {
            

        }



        public void readFromFile()
        {
            var filePath = ""; //example 
            string str = File.ReadAllText(filePath);
            var values = str.Split("\t");
            int i = 9;
            values[9] = values[9].Substring(2, values[9].Length - 2);
            while (i < values.Length - 1)
            {
               string date     =  values[i].Replace("\r\n", "");
               string label    =  values[1 + i];
               string title    =  values[2 + i];
               string author   =  values[3 + i];
               string artist   =  values[4 + i];
               string ISBN13   =  values[5 + i];
               string page     =  values[8 + i];
                i = i + 8;
                parse(date, label, title, author, artist, ISBN13, page);
            }

        }
        public void saveToDatabase()
        {
            throw new NotImplementedException();
        }
    }
}
