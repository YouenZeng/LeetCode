using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.LeetAgain
{
    internal class LargestDivisibleSubsetSln : ISolution
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        public IList<int> LargestDivisibleSubset(int[] nums)
        {
            IList<int> result = new List<int>();
            if (nums.Length == 0) return result;
            Array.Sort(nums);

            int[] dp = new int[nums.Length];
            int[] dpPrev = new int[nums.Length];

            int max = 0, maxIndex = -1;
            for (int i = 0; i < nums.Length; i++)
            {
                dp[i] = 1;
                dpPrev[i] = -1;
                for (int j = i - 1; j >= 0; j--)
                {
                    if (nums[i] % nums[j] == 0)
                    {
                        if (dp[j] + 1 > dp[i])
                        {
                            dp[i] = dp[j] + 1;
                            dpPrev[i] = j;
                        }
                    }
                }

                if (dp[i] > max)
                {
                    max = dp[i];
                    maxIndex = i;
                }
            }


            while (maxIndex !=-1)
            {
                result.Add(nums[maxIndex]);
                maxIndex = dpPrev[maxIndex];
            }

            return result;
        }

        public void Execute()
        {
            LargestDivisibleSubset(new int[] { 3, 4, 6, 9, 12, 14, 18, 24 });
        }
    }
}
