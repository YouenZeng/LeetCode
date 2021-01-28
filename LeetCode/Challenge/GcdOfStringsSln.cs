using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Challenge
{
    class GcdOfStringsSln : ISolution
    {
        public string GcdOfStrings(string str1, string str2)
        {
            int s1 = str1.Length;
            int s2 = str2.Length;
            for (int i = s1; i > 0; i--)
            {
                if (s1 % i != 0 || s2 % i != 0)
                {
                    continue;
                }

                string s = str1.Substring(0, i);
                if (str1.Replace(s, "") == string.Empty && str2.Replace(s, "") == string.Empty)
                {
                    return s;
                }
            }

            return string.Empty;
        }

        public void Execute()
        {
            GcdOfStrings("LEET", "CODE");
        }
    }
}