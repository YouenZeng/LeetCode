using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Challenge
{
    class RemoveDuplicatesSln : ISolution
    {
        public int RemoveDuplicates(int[] nums)
        {
            if (nums.Length == 0)
            {
                return 0;
            }
            int prevNum = nums[0];
            int prevCount = 1;
            int endIndex = nums.Length - 1;
            int start = 1;
            while (start <= endIndex)
            {
                if (nums[start] == prevNum)
                {
                    if (prevCount == 2)
                    {
                        for (int i = start; i < endIndex; i++)
                        {
                            Swap(nums, i, 1 + i);
                        }
                        endIndex--;
                        continue;
                    }
                    else
                    {
                        prevCount++;
                    }

                }
                else
                {
                    prevNum = nums[start];
                    prevCount = 1;
                }

                start++;
            }
            return endIndex + 1;
        }

        private void Swap(int[] nums, int from, int to)
        {
            int temp = nums[from];
            nums[from] = nums[to];
            nums[to] = temp;
        }

        public void Execute()
        {
            Console.WriteLine(RemoveDuplicates(new int[] { 1, 1, 1 }));
            Console.WriteLine(RemoveDuplicates(new int[] { 1 }));
            Console.WriteLine(RemoveDuplicates(new int[] { -1, 2, 3 }));
            Console.WriteLine(RemoveDuplicates(new int[] { 1, 1, 1, 2, 2, 3 }));
            Console.WriteLine(RemoveDuplicates(new int[] { 0, 0, 1, 1, 1, 1, 2, 3, 3, 3 }));
        }
    }
}
