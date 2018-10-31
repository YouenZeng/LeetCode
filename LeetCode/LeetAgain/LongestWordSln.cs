using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode.LeetAgain
{
    class LongestWordSln : ISolution
    {
        public string LongestWord(string[] words)
        {
            Array.Sort(words);
            HashSet<String> built = new HashSet<String>();
            String res = "";
            foreach (String w in words)
            {
                if (w.Length == 1 || built.Contains(w.Substring(0, w.Length - 1)))
                {
                    res = w.Length > res.Length ? w : res;
                    built.Add(w);
                }
            }
            return res;
        }


        public void Execute()
        {
            LongestWord(new string[] { "o", "wr", "wor", "worl", "world" });
            LongestWord(new string[] { "w", "wo", "wor", "worl", "world", "f", "fo", "for", "forl", "forld" });
        }
    }
}
