using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions;


namespace LNBServer
{
    public class ISBN : IEquatable<ISBN>
    {
        private uint _isbn;

        public string ISBN10
        {
            get
            {
                string r = "";

                uint x = 1_000_000_000;
                uint s = 0;
                uint m = 2;

                for(int i = 0; i < 9; i += 1)
                {
                    var digit = ( _isbn / x ) % 10;
                    x /= 10;
                    s += (digit % 10) % m;
                    m += 1;

                    r += digit.ToString();
                }

                uint c = (11 - s % 11) % 11;

                if(c < 10)
                {
                    r += c.ToString();
                }
                else
                {
                    r += "X";
                }

                return r;
            }
            set
            {
                uint x = 0;
                uint n = 0;

                foreach(char c in value.ToUpper())
                {
                    if( c < '0' || c > '9' )
                    {
                        continue;
                    }

                    var digit = (uint)(c - '0');

                    x *= 10;
                    x += digit;

                    n += 1;

                    if(n == 9)
                    {
                        break;
                    }
                }

                if (n != 9 || ISBN10.Last() != value.Trim().ToUpper().Last())
                {
                    throw new Exception($"Not a recognized ISBN10 value: {value}");
                }

                _isbn = x;
            }
        }
        public string ISBN13
        {
            get
            {
                string r = "978";
                uint x = 1_000_000_000;
                uint s = 9*1 + 7*3 + 8*1;

                for (uint i = 0; i < 9; i += 1)
                {
                    var digit = (_isbn / x) % 10;
                    x /= 10;

                    r += digit.ToString();

                    uint oneOrThree = 1 + (((i + 3) % 2) * 2); // 1, 3, 1, 3, [...], 1, 3
                    s += digit * oneOrThree;
                }

                uint c = (10 - (s % 10)) % 10;
                r += c.ToString();

                return r;
            }
            set
            {
                uint x = 0;
                uint n = 0;

                if (!value.Trim().StartsWith("978"))
                {
                    throw new Exception($"Not a recognized ISBN13 value: {value}");
                }

                foreach (char c in value.AsSpan().Trim().Slice(3))
                {
                    if (c < '0' || c > '9')
                    {
                        continue;
                    }

                    var digit = (uint)(c - '0');

                    x *= 10;
                    x += digit;

                    n += 1;

                    if (n == 9)
                    {
                        break;
                    }
                }

                if (n != 9 || ISBN13.Last() != value.Trim().Last())
                {
                    throw new Exception($"Not a recognized ISBN13 value: {value}");
                }

                _isbn = x;
            }
        }
        public bool IsValid { get => _isbn != 0; }

        private static uint CountDigits(string x)
        {
            uint n = 0;
            foreach(char c in x)
            {
                if( c >= '0' && c <= '9')
                {
                    n += 1;
                }
            }
            return n;
        }

        public ISBN(string isbn)
        {
            var numDigits = CountDigits(isbn);

            if (numDigits == 10 || (numDigits == 9 && isbn.Trim().ToUpper().Last() == 'X'))
            {
                ISBN10 = isbn;
            }
            else if(numDigits == 13)
            {
                ISBN13 = isbn;
            }
            else
            {
                throw new Exception($"Unknown ISBN format: {isbn}");
            }
        }
        public ISBN(uint isbn)
        {
            _isbn = isbn;
        }

        public bool Equals(ISBN other)
        {
            return _isbn == other._isbn;
        }

        public override bool Equals(object other)
        {
            if (other is string s)
            {
                return Equals(new ISBN(s));
            }
            else if(other is ISBN isbn)
            {
                return Equals(isbn);
            }
            else if(other is uint x)
            {
                return _isbn == x;
            }

            return false;
        }
        public override int GetHashCode()
        {
            return (int)_isbn;
        }

        public static implicit operator int(ISBN x)
        {
            return (int)x._isbn;
        }
        public static explicit operator ISBN(int x)
        {
            return new ISBN((uint)x);
        }
    }
}

