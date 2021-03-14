using System;

namespace LeetCode.LeetAgain
{
    class MinimumDeleteSumSln : ISolution
    {
        public int MinimumDeleteSum(string s1, string s2)
        {
            int[,] arr = new int[s1.Length + 1, s2.Length + 1];

            for (int i = 1; i <= s1.Length; i++)
            {
                arr[i, 0] = arr[i - 1, 0] + s1[i - 1];
            }

            for (int i = 1; i <= s2.Length; i++)
            {
                arr[0, i] = arr[0, i - 1] + s2[i - 1];

                for (int j = 1; j <= s1.Length; j++)
                {
                    if (s2[i - 1] == s1[j - 1])
                        arr[j, i] = arr[j - 1, i - 1];
                    else
                    {
                        arr[j, i] = Math.Min(arr[j, i - 1] + s2[i - 1], arr[j - 1, i] + s1[j - 1]);
                    }
                }
            }

            return arr[s1.Length, s2.Length];
        }

        public void Execute()
        {
            MinimumDeleteSum("delete", "leet");
        }
    }
}