using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.LeetAgain
{
    class Find132patternSln : ISolution
    {
        public bool Find132pattern(int[] nums)
        {
            int s3 = int.MinValue;
            Stack<int> stack = new Stack<int>();
            for (int i = nums.Length - 1; i >= 0; i--)
            {
                if (nums[i] < s3)
                {
                    return true;
                }
                else
                {
                    while (stack.Count > 0 && nums[i] > stack.Peek())
                    {
                        s3 = stack.Pop();
                    }
                }

                stack.Push(nums[i]);
            }
            return false;
        }
        public void Execute()
        {
            Console.WriteLine(Find132pattern(new[] { -2, 1, 2, -2, 1, 2 }));
            Console.WriteLine(Find132pattern(new[] { 3, 1, 4, 2 }));
            Console.WriteLine(Find132pattern(new[] { 3, 1, -5, -4 }));
        }
    }
}
