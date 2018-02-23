using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace LeetCode.LeetAgain
{
    public class FindSubstringInWraproundStringSln : ISolution
    {
        public int FindSubstringInWraproundString(string p)
        {

            int[] result = new int[26];
            int adjCount = 1;
            for (int i = 0; i < p.Length; i++)
            {
                //adj chars
                if (i > 0 && ((p[i - 1] == 'z' && p[i] == 'a') || p[i] - p[i - 1] == 1))
                {
                    adjCount++;
                }
                else
                {
                    adjCount = 1;
                }

                int index = p[i] - 'a';
                result[index] = Math.Max(result[index], adjCount);
            }
            int count = 0;
            foreach (var item in result)
            {
                count += item;
            }
            return count;
        }
        void ISolution.Execute()
        {
            FindSubstringInWraproundString("abcdbcd");
        }
    }
}