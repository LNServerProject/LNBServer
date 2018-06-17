using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LNBServer
{

    public class ISBN
    {
        private string _isbn;
        public string ISBN10 { get => _isbn; }
        public bool IsValid { get => _isbn.Length != 0; }

        public ISBN(string isbn)
        {
            _isbn = isbn;
        }

        public static ISBN convert(string isbn)
        {
            int sum = 0;
            isbn = isbn.Replace("-", "");

            if (isbn.Length < 13)
            {
                return new ISBN(isbn);
            }

            string relevantDigits = isbn.Substring(3, 9);
            for (int i = 0; i < relevantDigits.Length; i++)
            {
                sum += (relevantDigits[i] - '0') * (10 - i);
            }

            int lastDigit = 11 - (sum % 11);

            if (lastDigit == 10)
            {
                relevantDigits = relevantDigits + "X";
            }
            else if (lastDigit == 11)
            {
                relevantDigits = relevantDigits + "0";
            }
            else
            {
                relevantDigits = relevantDigits + lastDigit.ToString();
            }

            return new ISBN(relevantDigits);
        }
    }
}

