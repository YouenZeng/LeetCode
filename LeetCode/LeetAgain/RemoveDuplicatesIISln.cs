using System;

namespace LeetCode.LeetAgain
{
    public class RemoveDuplicatesIISln : ISolution
    {
        public int RemoveDuplicates(int[] nums)
        {
            //1,1,1,2,2,3,4,4,4,5,6
            int i = 0;
            foreach (var num in nums)
            {
                if (i < 2 || num > nums[i - 2])
                    nums[i++] = num;
            }

            return i;
        }

        public void Execute()
        {
            RemoveDuplicates(new[] {1, 1, 2, 2, 2, 3, 4, 4, 4, 5, 6});
        }
    }
}