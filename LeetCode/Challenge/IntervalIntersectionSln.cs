using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode.Challenge
{
    class IntervalIntersectionSln : ISolution
    {
        public int[][] IntervalIntersection(int[][] A, int[][] B)
        {
            List<int[]> ans = new List<int[]>();
            int i = 0, j = 0;

            while (i < A.Length && j < B.Length)
            {
                // Let's check if A[i] intersects B[j].
                // lo - the startpoint of the intersection
                // hi - the endpoint of the intersection
                int lo = Math.Max(A[i][0], B[j][0]);
                int hi = Math.Min(A[i][1], B[j][1]);
                if (lo <= hi)
                {
                    ans.Add(new int[] {lo, hi});
                }

                // Remove the interval with the smallest endpoint
                if (A[i][1] < B[j][1])
                {
                    i++;
                }
                else
                {
                    j++;
                }
            }

            return ans.ToArray();
        }

        public void Execute()
        {
            int[][] first = new int[4][]
            {
                new[] {0, 2}, new[] {5, 10}, new[] {13, 23}, new[] {24, 25}
            };
            int[][] second = new int[4][] {new[] {1, 5}, new[] {8, 12}, new[] {15, 24}, new[] {25, 26}};

           

            IntervalIntersection(first, second);
        }
    }
}