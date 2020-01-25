using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;

namespace LeetCode.LeetAgain
{
    class FindMaxLengthSln : ISolution
    {
        public int FindMaxLength(int[] nums)
        {
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] == 0)
                    nums[i] = -1;
            }

            Dictionary<int, int> dict = new Dictionary<int, int>();
            dict.Add(0, -1);
            int sum = 0;
            int result = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                sum += nums[i];
                if (dict.ContainsKey(sum))
                {
                    result = Math.Max(result, i - dict[sum]);
                }
                else
                {
                    dict.Add(sum, i);
                }
            }

            return result;
        }

        public void Execute()
        {
            FindMaxLength(new[] { 0, 1, 1, 0, 1, 1, 1, 0 });
            FindMaxLength(new[] { 0, 0, 1, 0, 0, 0, 1, 1 });
            FindMaxLength(new[] { 1, 1, 1, 0, 0, 0 });
            FindMaxLength(new[] { 0, 11, 1, 10, 10, 2 });
            FindMaxLength(new[] { -1, 1, 1, 0, 20, 2, 1, 1, 1, 0, 0, 0, 1, 0 });
        }
    }
}