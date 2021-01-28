using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode.Challenge
{
    class LongestStrChainSln : ISolution
    {
        public int LongestStrChain(string[] words)
        {
            Array.Sort(words, (s, s1) => s1.Length.CompareTo(s.Length));
            int max = 1;
            Dictionary<string, int> dict = new Dictionary<string, int>();
            foreach (string w in words)
            {
                dict[w] = 1;
            }

            foreach (string w in words)
            {
                for (int i = 0; i < w.Length; i++)
                {
                    string s = w.Substring(0, i) + w.Substring(i + 1, w.Length - i - 1);
                    if (dict.ContainsKey(s))
                    {
                        dict[s] = Math.Max(dict[s], dict[w] + 1);
                    }
                }
            }

            return dict.Max(d=>d.Value);
        }

        public void Execute()
        {
            LongestStrChain(new[] {"xbc", "pcxbcf", "x", "cxbcc", "pcxbc"});
        }
    }
}