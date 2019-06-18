using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace LeetCode.LeetAgain
{
    class NumRescueBoatsSln : ISolution
    {
        public int NumRescueBoats(int[] people, int limit)
        {
            //greedy
            Array.Sort(people);
            int count = 0;

            int start = 0;
            int end = people.Length - 1;

            var target = limit - people[start];
            while (people[end] > target && start <= end && end > 0)
            {
                end--;
            }

            int endIdx = end;
            while (start <= end)
            {
                target = limit - people[start];

                if (people[end] <= target)
                {
                    start++;
                    end--;
                    count++;
                }
                else
                {
                    count++;
                    end--;
                }
            }

            return count + people.Length - endIdx - 1;
        }
        public void Execute()
        {
            NumRescueBoats(new[] { 1, 2, 2, 3 }, 3);
            NumRescueBoats(new[] { 1, 2, 3, 4, 5, 6, 7, 8 }, 9);
            NumRescueBoats(new[] { 11, 12, 13, 14, 15, 16, 17, 18 }, 19);
        }
    }
}
