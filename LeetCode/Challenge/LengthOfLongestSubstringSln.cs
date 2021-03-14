using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Challenge
{
    class LengthOfLongestSubstringSln : ISolution
    {
        public int LengthOfLongestSubstring(string s)
        {
            int maxLength = 0;
            int subStart = 0;
            HashSet<char> hs = new HashSet<char>();
            for (int i = 0; i < s.Length; i++)
            {
                if (!hs.Add(s[i]))
                {
                    maxLength = Math.Max(maxLength, i - subStart);
                    for (int j = subStart; i <= i; j++)
                    {
                        if (s[j] == s[i])
                        {
                            subStart =1+ j;
                            break;
                        }
                        else
                        {
                            hs.Remove(s[j]);
                        }
                    }
                }
            }
            maxLength = Math.Max(maxLength, s.Length - subStart);
            return maxLength;
        }
        public void Execute()
        {
            LengthOfLongestSubstring("");
        }
    }
}
