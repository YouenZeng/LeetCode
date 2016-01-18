using System;
using System.Collections.Generic;

namespace LeetCode.Leets
{
    class WordPatternSln : ISolution
    {
        public bool WordPattern(string pattern, string str)
        {
            string[] strs = str.Split(' ');
            if (pattern.Length != strs.Length) return false;

            Dictionary<char, string> dict = new Dictionary<char, string>();
            for (int i = 0; i < pattern.Length; i++)
            {
                if (dict.ContainsKey(pattern[i]) == false)
                {
                    dict.Add(pattern[i], strs[i]);
                }
                else
                {
                    if (dict[pattern[i]] != strs[i])
                    {
                        return false;
                    }
                }
            }

            HashSet<string> hs = new HashSet<string>();
            foreach (KeyValuePair<char, string> pair in dict)
            {
                hs.Add(pair.Value);
            }
            return hs.Count == dict.Count;
        }
        public void Execute()
        {
            Console.WriteLine(WordPattern("abba", "dog cat cat d3og"));
        }
    }
}
