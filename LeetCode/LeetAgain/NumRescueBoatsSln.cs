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
            int pCount = people.Length;
            for (int i = 0, j = pCount - 1; i <= j; j--, count++)
            {
                if (people[i] + people[j] <= limit)
                {
                    i++;
                }
            }

            //Console.WriteLine(count);
            return count;
        }

        public void Execute()
        {
            NumRescueBoats(new[] { 1, 2 }, 3);
            NumRescueBoats(new[] { 1, 2, 2, 3 }, 3);
            NumRescueBoats(new[] { 1, 2, 3, 4, 5, 6, 7, 8 }, 9);
            NumRescueBoats(new[] { 11, 12, 13, 14, 15, 16, 17, 18 }, 19);
        }
    }
}