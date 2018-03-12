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
            int hsStartIndex = 0;
            for (int i = 0; i < s.Length; i++)
            {
                if (hs.Add(s[i]) == false)
                {
                    currentMax = Math.Max(hs.Count, currentMax);

                    bool repeatFound = false;
                    for (int j = hsStartIndex; j <= i; j++)
                    {
                        if (s[j] == s[i] && repeatFound == false)
                        {
                            repeatFound = true;
                            hsStartIndex = j + 1;
                            hs.Clear();
                            continue;
                        }
                        if (repeatFound)
                        {
                            hs.Add(s[j]);
                        }
                    }
                }
            }

            return Math.Max(currentMax, hs.Count);
        }
        public void Execute()
        {
            LengthOfLongestSubstring("abcdbfghija");
        }
    }
}
