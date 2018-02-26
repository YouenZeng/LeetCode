using System;
using System.Linq;

namespace LeetCode.LeetAgain
{
    class FindMaxFormSln : ISolution
    {
        public int FindMaxForm(string[] strs, int m, int n)
        {
            int[,] cache = new int[m + 1, n + 1];
            foreach (string s in strs)
            {
                int[] count = Count(s);
                for (int i = m; i >= count[0]; i--)
                {
                    for (int j = n; j >= count[1]; j--)
                    {
                        cache[i, j] = Math.Max(1 + cache[i - count[0], j - count[1]], cache[i, j]);
                    }
                }
            }
            return cache[m, n];
        }

        public int[] Count(String str)
        {
            int[] res = new int[2];
            for (int i = 0; i < str.Length; i++)
                res[str[i] - '0']++;
            return res;
        }
        public void Execute()
        {
            Console.WriteLine(FindMaxForm(new string[] { "111", "1000", "1000", "1000" }, 9, 3)); ;
        }
    }
}
