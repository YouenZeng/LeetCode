using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Challenge
{
    class MostCompetitiveSln : ISolution
    {
        public int[] MostCompetitive(int[] nums, int k)
        {
            Stack<int> stack = new Stack<int>();
            int[] result = new int[k];
            for (int i = 0; i < nums.Length; i++)
            {
                while (stack.Count > 0 && nums[i] < nums[stack.Peek()] && nums.Length - i + stack.Count > k)
                {
                    stack.Pop();
                }

                if (stack.Count < k)
                {
                    stack.Push(i);
                }
            }

            for (int i = k - 1; i >= 0; i--)
            {
                result[i] = nums[stack.Pop()];
            }

            return result;
        }

        public void Execute()
        {
            MostCompetitive(new int[] {2, 4, 3, 3, 5, 4, 9, 6}, 4);
            MostCompetitive(new int[] {3, 5, 2, 6}, 2);
        }
    }
}