using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode.Challenge
{
    class TopKFrequentSln : ISolution
    {
        public IList<string> TopKFrequent(string[] words, int k)
        {
            Dictionary<string, int> dict = new Dictionary<string, int>();
            List<string> l = new List<string>();

           

            foreach (var w in words)
            {
              var ccc =  w.Count(s => s == 'a');
                if (dict.ContainsKey(w))
                {
                    dict[w]++;
                }
                else
                {
                    l.Add(w);
                    dict[w] = 1;
                }
            }

            l.Sort((s, s1) => s1.Length == s.Length
                ? String.Compare(s, s1, StringComparison.Ordinal)
                : (dict[s1] - dict[s]));

            return l.Take(k).ToList();
        }

        public void Execute()
        {
            throw new NotImplementedException();
        }
    }
}