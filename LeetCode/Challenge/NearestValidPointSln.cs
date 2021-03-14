using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Challenge
{
    class NearestValidPointSln : ISolution
    {
        public int NearestValidPoint(int x, int y, int[][] points)
        {
            int min = int.MaxValue;
            int minDistance = int.MaxValue;
            for (int i = 0; i < points.Length; i++)
            {
                int[] point = points[i];
                if (point[0] == x || point[1] == y)
                {
                    if (Math.Abs(point[0] - x) + Math.Abs(point[1] - y) < minDistance)
                    {
                        minDistance = Math.Abs(point[0] - x) + Math.Abs(point[1] - y);
                        min = i;
                    }
                }
            }

            return min == int.MaxValue ? -1 : min;
        }

        public void Execute()
        {
            throw new NotImplementedException();
        }
    }
}