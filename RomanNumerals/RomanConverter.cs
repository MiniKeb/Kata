using System;
using System.Collections.Generic;

using System.Linq;

namespace RomanNumerals
{
    public class RomanConverter
    {
        private readonly Dictionary<int, string> baseValues;

        public RomanConverter()
        {
            baseValues = new Dictionary<int, string>
            {
                {1000, "M"},
                {500, "D"},
                {100, "C"},
                {50, "L"},
                {10, "X"},
                {5, "V"},
                {1, "I"},
            };
        }

        public string Convert(int number)
        {
            string romanNumber = "";

            var remainingValue = number;
            foreach (var pair in baseValues)
            {
                /*var minus = baseValues.FirstOrDefault(p => remainingValue == pair.Key - p.Key);
                if (!minus.Equals(new KeyValuePair<int, string>()))
                {
                    romanNumber += minus.Value;
                    remainingValue += minus.Key;
                }*/

                int valueCount = remainingValue / pair.Key;
                for (int x = 0; x < valueCount; x++)
                {
                    romanNumber += pair.Value;
                }
                remainingValue %= pair.Key;

            }

            return romanNumber
                .Replace("IIII", "IV")
                .Replace("VIV", "IX")
                .Replace("XXXX", "XL")
                .Replace("LXL","XC")
                ;
        }
    }
}