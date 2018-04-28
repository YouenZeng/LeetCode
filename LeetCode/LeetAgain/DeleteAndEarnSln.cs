using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode.LeetAgain
{
    class DeleteAndEarnSln : ISolution
    {
        public int DeleteAndEarn(int[] nums)
        {
            Array.Sort(nums);
            Dictionary<int, int> dict = new Dictionary<int, int>();
            HashSet<int> hs = new HashSet<int>();
            foreach (var num in nums)
            {
                if (dict.ContainsKey(num))
                {
                    dict[num] += num;
                }
                else
                {
                    dict.Add(num, num);
                    hs.Add(num);
                }
            }

            int currentMax = 0;
            int prev = 0;
            int prevPrev = 0;
            foreach (var kvp in hs)
            {
                currentMax = Math.Max(
                    (dict.ContainsKey(kvp - 2) ? dict[kvp - 2] : prevPrev) + dict[kvp],
                    dict.ContainsKey(kvp - 1) ? dict[kvp - 1] : prev + dict[kvp]);
                dict[kvp] = currentMax;
                prevPrev = prev;
                prev = currentMax;
            }

            return currentMax;
        }

        public void Execute()
        {
            Console.WriteLine(DeleteAndEarn(new[] {3, 4, 2}));
            Console.WriteLine(DeleteAndEarn(new[] {3, 3, 3, 3, 4, 2}));
            Console.WriteLine(DeleteAndEarn(new[] {1, 1, 11, 3, 4, 2, 10000}));
            Console.WriteLine(DeleteAndEarn(new[] {1, 1, 1, 2, 4, 5, 5, 5, 6}));
        }
    }
}