using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LeetCode.Leets;


namespace LeetCode.LeetAgain
{
    public class RemoveDuplicatesSln : ISolution
    {
        public int RemoveDuplicates(int[] nums)
        {
            if (nums.Length == 0) return 0;
            int slow = 0;
            int fast = 0;
            while (fast < nums.Length)
            {
                if (nums[slow] != nums[fast])
                {
                    slow++;
                    Swap(nums, slow, fast);
                }
                fast++;
            }
            return slow + 1;
        }


        void Swap(int[] nums, int fromIndex, int toIndex)
        {
            int temp = nums[fromIndex];
            nums[fromIndex] = nums[toIndex];
            nums[toIndex] = temp;
        }

        public void Execute()
        {
            int[] nums = { 1, 2, 3, 3, 3, 4 };
            RemoveDuplicates(nums);
        }
    }
}
