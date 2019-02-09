using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetCode.LeetAgain
{
    internal class CanReorderDoubledSln : ISolution
    {
        public bool CanReorderDoubled(int[] A)
        {
            Dictionary<int, int> dict = new Dictionary<int, int>();

            for (int i = 0; i < A.Length; i++)
            {
                if (A[i] < 0)
                    A[i] = A[i] * -1;
                if (dict.ContainsKey(A[i]))
                    dict[A[i]] += 1;
                else
                    dict.Add(A[i], 1);
            }

            HashSet<int> hs = dict.Select(d => d.Key).OrderBy(d => d).ToHashSet();
            
            foreach (int item in hs)
            {
                if (dict[item] == 0) continue;
                if (dict.ContainsKey(item * 2) && dict[item * 2] >= dict[item])
                {
                    dict[item * 2] -= dict[item];
                    continue;
                }

                return false;
            }

            return true;
        }
        public void Execute()
        {
            Console.WriteLine(CanReorderDoubled(new int[] { 1, 2, 1, -8, 8, -4, 4, -4, 2, -2 }));
            Console.WriteLine(CanReorderDoubled(new int[] { 0, 0, 0, 0 }));
            Console.WriteLine(CanReorderDoubled(new int[] { 4, -2, 2, -4 }));
        }
    }
}
