using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace LeetCode.Challenge
{
    class FindDuplicatesSln : ISolution
    {
        public IList<int> FindDuplicates(int[] nums)
        {
            List<int> result = new List<int>();
            for (int i = 0; i < nums.Length; i++)
            {
                while (nums[i] != nums[nums[i] - 1] && i + 1 != nums[i])
                {
                    int t = nums[nums[i] - 1];
                    nums[nums[i] - 1] = nums[i];
                    nums[i] = t;
                }
            }


            for (int i = 0; i < nums.Length; i++)
            {
                //move to index nums[i] - 1
                if (i + 1 != nums[i])
                {
                    result.Add(nums[i]);
                }
            }

            return result;
        }


        public void Execute()
        {
            FindDuplicates(new int[] {4, 3, 2, 7, 8, 2, 3, 1});
        }
    }
}