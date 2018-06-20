using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.LeetAgain
{
    class LengthOfLongestSubstringSln : ISolution
    {

        public int LengthOfLongestSubstring(string s)
        {
            int currentMax = 0;
            HashSet<char> hs = new HashSet<char>();
            int[] charCache = new int[256];
            for (int i = 0; i < s.Length; i++)
            {
                if (hs.Add(s[i]) == false)
                {
                    currentMax = Math.Max(hs.Count, currentMax);
                    hs.Clear();
                    for (int j = charCache[Convert.ToInt32(s[i])] + 1; j <= i; j++)
                    {
                        hs.Add(s[j]);
                    }
                }
                charCache[Convert.ToInt32(s[i])] = i;
            }

            return Math.Max(currentMax, hs.Count);
        }
        public int LengthOfLongestSubstringV2(string s)
        {
            int currentMax = 0;
            Dictionary<char, int> map = new Dictionary<char, int>();
            for (int i = 0, j = 0; i < s.Length; i++)
            {
                if (map.ContainsKey(s[i]))
                {
                    j = Math.Max(j, map[s[i]] + 1);
                    map[s[i]] = i;
                }
                else { map.Add(s[i], i); }

                currentMax = Math.Max(currentMax, i - j + 1);
            }

            return currentMax;
        }


        public void Execute()
        {
            LengthOfLongestSubstringV2("uwevuuk");
        }
    }
}
