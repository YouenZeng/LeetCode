using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Challenge
{
    class HasAllCodesSln : ISolution
    {
        public bool HasAllCodes(string s, int k)
        {
            int need = 1 << k;
            HashSet<string> got = new HashSet<string>();

            for (int i = k; i <= s.Length; i++)
            {
                string a = s.Substring(i - k, k);
                if (!got.Contains(a))
                {
                    got.Add(a);
                    need--;
                    // return true when found all occurrences
                    if (need == 0)
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        public void Execute()
        {
            HasAllCodes("0000000001011100", 4);
        }
    }
}
