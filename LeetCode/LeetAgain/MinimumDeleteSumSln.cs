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
                for (int j = 0; j < s2.Length; j++)
                {
                    arr[i, j] = s1[i];
                }
            }

            for (int j = 0; j < s2.Length; j++)
            {
                for (int i = 0; i < s1.Length; i++)
                {
                    arr[j, i] += s2[j];
                }
            }

            int startIndex = 0;
            for (int i = 0; i < s1.Length; i++)
            {
                int min = int.MaxValue;
                for (int j = startIndex; j < s2.Length; j++)
                {
                }
            }

            return result;
        }

        public void Execute()
        {
            MinimumDeleteSum("leet", "delete");
        }
    }
}