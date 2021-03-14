using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode.Challenge
{
    class MinimumDeviationSln : ISolution
    {
        public int MinimumDeviation(int[] nums)
        {
            PriorityQueue<int> pq =
                new PriorityQueue<int>(10, Comparer<int>.Create((x, y) => y.CompareTo(x)));
            int result = int.MaxValue;
            int min = int.MaxValue;
            
            foreach (int num in nums)
            {
                int n = num;
                if (num % 2 == 1)
                {
                    n = n * 2;
                }

                pq.Push(n);
                min = Math.Min(min, n);
            }

            while (pq.Top % 2 == 0)
            {
                result = Math.Min(result, pq.Top - min);
                min = Math.Min(min, pq.Top / 2);
                pq.Push(pq.Top / 2);
                pq.Pop();
            }

            return Math.Min(result, pq.Top - min);
        }

        public void Execute()
        {
            MinimumDeviation(new int[] {1, 2, 3,4});
        }
    }
}