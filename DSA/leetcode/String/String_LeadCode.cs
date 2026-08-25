using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.leetcode.String
{
    internal class String_LeadCode:IString_LeadCode
    {
        public int MyAtoi(string s)
        {
            int i = 0, sign = 1, result = 0;
            
            while (i < s.Length && s[i] == ' ')
                i++;
            
            if (i < s.Length && (s[i] == '-' || s[i] == '+'))
                sign = (s[i++] == '-') ? -1 : 1;
            
            while (i < s.Length && char.IsDigit(s[i]))
            {
                int digit = s[i++] - '0';
                
                if (result > (int.MaxValue - digit) / 10)
                    return sign == 1 ? int.MaxValue : int.MinValue;
                result = result * 10 + digit;
            }
            return result * sign;
        }
        public int RomanToInt(string s)
        {
            Dictionary<char,int> romanMap = new Dictionary<char, int>
            {
                {'I', 1},
                {'V', 5},
                {'X', 10},
                {'L', 50},
                {'C', 100},
                {'D', 500},
                {'M', 1000}
            };
            int total = 0;
            for (int i = 0; i < s.Length; i++)
            {
                if (i + 1 < s.Length && romanMap[s[i]] < romanMap[s[i + 1]])
                {
                    total -= romanMap[s[i]];
                }
                else
                {
                    total += romanMap[s[i]];
                }
            }
            return total;
        }
        public string IntToRoman(int num)
        {
            (int value, string symbol)[] romanNumerals =
             {
                (1000, "M"),
                (500, "D"),
                (100, "C"),
                (50, "L"),
                (10, "X"),
                (5, "V"),
                (1, "I")
            };

            string result = "";

            for (int i = 0; i < romanNumerals.Length; i++)
            {
                int value = romanNumerals[i].value;
                string symbol = romanNumerals[i].symbol;

                int nextValue = i + 1 < romanNumerals.Length
                    ? romanNumerals[i + 1].value
                    : 0;

                string nextSymbol = i + 1 < romanNumerals.Length
                    ? romanNumerals[i + 1].symbol
                    : "";

                // Subtractive case
                if (num >= value - nextValue && num < value)
                {
                    result += nextSymbol + symbol;
                    num -= value - nextValue;
                }

                while (num >= value)
                {
                    result += symbol;
                    num -= value;
                }
            }

            return result;
        }
        public int LengthOfLastWord(string s)
        {
            int length = 0;
            int i = s.Length - 1;
            // Skip trailing spaces
            while (i >= 0 && s[i] == ' ')
            {
                i--;
            }
            // Count the length of the last word
            while (i >= 0 && s[i] != ' ')
            {
                length++;
                i--;
            }
            return length;
        }
    }
}
