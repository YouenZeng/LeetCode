using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.LeetAgain
{
    class FindDuplicateSln : ISolution
    {
        public int FindDuplicate(int[] nums)
        {
            if (nums.Length > 1)
            {
                int slow = nums[0];
                int fast = nums[nums[0]];
                while (slow != fast)
                {
                    slow = nums[slow];
                    fast = nums[nums[fast]];
                }

                fast = 0;
                while (fast != slow)
                {
                    fast = nums[fast];
                    slow = nums[slow];
                }
                return slow;
            }
            return -1;
        }
        public void Execute()
        {
            Console.WriteLine(FindDuplicate(new[] { 1, 2, 4, 4, 5, 6, 7 }));
        }
    }
}
