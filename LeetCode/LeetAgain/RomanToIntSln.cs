using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.LeetAgain
{
    class RomanToIntSln : ISolution
    {
        public int RomanToInt(string s)
        {
            Dictionary<char, int> dict = new Dictionary<char, int>()
            {
                {'I',1 },
                {'V',5 },
                {'X',10 },
                {'L',50 },
                {'C',100 },
                {'D',500 },
                {'M',1000 },
            };

            int prev = 0;
            int result = 0;
            for (int i = s.Length - 1; i >= 0; i--)
            {
                if (dict[s[i]] >= prev)
                {
                    result += dict[s[i]];
                    prev = dict[s[i]];
                }
                else
                {
                    result -= dict[s[i]];
                }
            }

            return result;
        }
        public void Execute()
        {
            RomanToInt("III");
            RomanToInt("MVI");
            RomanToInt("MD");
        }
    }
}
