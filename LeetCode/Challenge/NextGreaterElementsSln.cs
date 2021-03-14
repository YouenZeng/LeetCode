using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Challenge
{
    class NextGreaterElementsSln : ISolution
    {
        public int[] NextGreaterElements(int[] nums)
        {
            Stack<int> stack1 = new Stack<int>();

            Dictionary<int, int> dict1 = new Dictionary<int, int>();

            for (int i = 0; i < nums.Length; i++)
            {
                while (stack1.Count > 0 && nums[stack1.Peek()] < nums[i])
                {
                    dict1[stack1.Pop()] = i;
                }
                stack1.Push(i);
            }

            for (int i = 0; i < nums.Length; i++)
            {
                while (stack1.Count > 0 && nums[stack1.Peek()] < nums[i])
                {
                    dict1[stack1.Pop()] = i;
                }
                stack1.Push(i);
            }

            int[] result = new int[nums.Length];
            for (int i = 0; i < nums.Length; i++)
            {
                if (dict1.ContainsKey(i))
                {
                    result[i] = nums[dict1[i]];
                }
                else
                {
                    result[i] = -1;
                }
            }
            return result;
        }

        public void Execute()
        {
            NextGreaterElements(new int[] {100, 1, 11, 1, 120, 111, 123, 1, -1, -100});
        }
    }
}