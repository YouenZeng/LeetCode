using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;

namespace LeetCode.LeetAgain
{
    class MinimumDeleteSumSln : ISolution
    {
        public int MinimumDeleteSum(string s1, string s2)
        {

            int result = 0;

            int[,] arr = new int[s1.Length, s2.Length];

            for (int i = 0; i < s1.Length; i++)
            {
                if (s2[i] == s1[i])
                {

                }
            }

            throw new NotImplementedException();

            return result;
        }

        public void Execute()
        {
            MinimumDeleteSum("leet", "delete");
        }
    }
}