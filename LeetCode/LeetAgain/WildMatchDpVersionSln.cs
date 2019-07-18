using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.LeetAgain
{
    class WildMatchDpVersionSln : ISolution
    {
        public bool IsMatch(string s, string p)
        {
            bool[,] cache = new bool[s.Length + 1, p.Length + 1];
            cache[0, 0] = true;

            for (int i = 1; i <= s.Length; i++)
            {
                cache[i, 0] = false;
            }

            for (int i = 1; i <= p.Length; i++)
            {
                if (p[i - 1] == '*')
                {
                    cache[0, i] = true;
                }
                else
                {
                    break;
                }
            }


            for (int i = 1; i <= s.Length; i++)
            {
                for (int j = 1; j <= p.Length; j++)
                {
                    if (p[j - 1] == '?' || p[j - 1] == s[i - 1])
                    {
                        cache[i, j] = cache[i - 1, j - 1];
                    }
                    else if (p[j - 1] == '*')
                    {
                        cache[i, j] = cache[i - 1, j] || cache[i, j - 1];
                    }
                }
            }

            return cache[s.Length, p.Length];

        }
        public void Execute()
        {
            Console.WriteLine(IsMatch("aadcad", "a?*df"));
        }
    }
}
