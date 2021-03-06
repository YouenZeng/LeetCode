﻿using System;
using System.Collections.Generic;

namespace LeetCode.LeetAgain
{
    internal class LongestConsecutiveSln : ISolution
    {
        public int LongestConsecutive(int[] nums)
        {
            int result = 0;
            Dictionary<int, int> cache = new Dictionary<int, int>();

            foreach (int item in nums)
            {
                if (!cache.ContainsKey(item))
                {
                    int left = cache.ContainsKey(item - 1) ? cache[item - 1] : 0;
                    int right = cache.ContainsKey(item + 1) ? cache[item + 1] : 0;

                    int sum = left + right + 1;

                    cache.Add(item, sum);
                    result = Math.Max(result, sum);
                    cache[item - left] = sum;
                    cache[item + right] = sum;
                }
            }

            return result;
        }


        public int LongestConsecutive2(int[] nums)
        {
            HashSet<int> numSet = new HashSet<int>(nums);
            HashSet<int> visisted = new HashSet<int>();
            int r = 0;
            foreach (var num in nums)
            {
                if (!visisted.Contains(num))
                {
                    int current = 0;
                    var stack = new Stack<int>();
                    stack.Push(num);

                    while (stack.Count > 0)
                    {
                        var p = stack.Pop();
                        visisted.Add(p);
                        current++;

                        if (numSet.Contains(p + 1) && !visisted.Contains(p + 1))
                        {
                            stack.Push(p + 1);
                        }

                        if (numSet.Contains(p - 1) && !visisted.Contains(p - 1))
                        {
                            stack.Push(p - 1);
                        }
                    }

                    r = Math.Max(r, current);
                }
            }

            return r;
        }

        public void Execute()
        {
            LongestConsecutive2(new int[] {100, 4, 200, 1, 3, 2, 5});
        }
    }
}