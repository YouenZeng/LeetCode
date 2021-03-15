using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode.Challenge
{
    class FindLongestWordSln : ISolution
    {
        public string FindLongestWord(string s, IList<string> d)
        {
            d = d.OrderByDescending(s2 => s2.Length).ThenBy(s1 => s1).ToList();


            foreach (string str in d)
            {
                bool match = true;

                int start = 0;
                int end = s.Length;

                int matchStart = 0;
                int matchEnd = str.Length;
                while (start < end && matchStart < matchEnd)
                {
                    if (str[matchStart] == s[start])
                    {
                        matchStart++;
                        start++;
                    }
                    else
                    {
                        start++;
                    }
                }

                if (matchStart == matchEnd)
                {
                    return str;
                }
            }

            return string.Empty;
        }

        public void Execute()
        {
            FindLongestWord("aewfafwafjlwajflwajflwafj", new List<string>() { "apple", "ewaf", "awefawfwaf", "awef", "awefe", "ewafeffewafewf" });
        }
    }
}