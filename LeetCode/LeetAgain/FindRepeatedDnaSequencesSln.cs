using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetCode.LeetAgain
{
    public class FindRepeatedDnaSequencesSln : ISolution
    {
        public IList<string> FindRepeatedDnaSequences(string s)
        {
            //use GetHashCode()
            HashSet<string> hs = new HashSet<string>();
            HashSet<string> hs2 = new HashSet<string>();
            for (int i = 10; i <= s.Length; i++)
            {
                if (!hs.Add(s.Substring(i - 10, 10)))
                {
                    hs2.Add(s.Substring(i - 10, 10));
                }
            }

            return hs2.ToList();
        }

        public void Execute()
        {
            var a = FindRepeatedDnaSequences("AAAAACCCCCAAAAACCCCCCAAAAAGGGTTT");
        }
    }
}