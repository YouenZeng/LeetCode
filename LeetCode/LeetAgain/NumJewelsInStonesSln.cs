using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.LeetAgain
{
    class NumJewelsInStonesSln : ISolution
    {
        public int NumJewelsInStones(string J, string S)
        {
            HashSet<char> hs = new HashSet<char>(J.ToCharArray());
            int count = 0;
            foreach (char c in S)
            {
                if (hs.Contains(c))
                    count++;
            }

            return count;
        }

        public void Execute()
        {
            throw new NotImplementedException();
        }
    }
}