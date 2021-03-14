using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Challenge
{
    class SubarraysDivByKSln : ISolution
    {
        public int SubarraysDivByK(int[] A, int K)
        {
            Dictionary<int, int> dict = new Dictionary<int, int>();
            int sum = 0;
            int result = 0;
            dict[0] = 1;
            for (int i = 0; i < A.Length; i++)
            {
                sum = (A[i] + sum) % K;
                if (sum < 0)
                {
                    sum += K;
                }

                if (dict.ContainsKey(sum))
                {
                    result += dict[sum];
                    dict[sum]++;
                }
                else
                {
                    dict[sum] = 1;
                }
            }

            return result;
        }

        public void Execute()
        {
            SubarraysDivByK(new int[] {4, 5, 0, -2, -3, 1}, 5);
        }
    }
}