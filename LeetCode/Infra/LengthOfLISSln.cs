using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode.Infra
{
    class LengthOfLISSln : ISolution
    {
        public int LengthOfLIS(int[] nums)
        {
            Dictionary<int, int> dict = new Dictionary<int, int>();
            int result = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                int max = 1;
                var d = dict.OrderByDescending(k => k.Key).FirstOrDefault(k => k.Key < nums[i]);
                max = Math.Max(max, d.Value + 1);

                dict[nums[i]] = max;
                result = Math.Max(result, max);
            }
            return result;
        }

        public void Execute()
        {
            Console.WriteLine(LengthOfLIS(new int[] { 1, 2, 2, 2, 2, 6 }));
            Console.WriteLine(LengthOfLIS(new int[] { 10, 9, 2, 5, 3, 7, 101, 18 }));
        }
    }
}
