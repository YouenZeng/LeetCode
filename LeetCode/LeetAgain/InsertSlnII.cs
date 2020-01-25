using System;
using System.Collections.Generic;

namespace LeetCode.LeetAgain
{
    class InsertSlnII : ISolution
    {
        public int[][] Insert(int[][] intervals, int[] newInterval)
        {
            bool isIntervalApplied = false;
            int left = newInterval[0];
            int right = newInterval[1];

            List<List<int>> result = new List<List<int>>();

            foreach (int[] interval in intervals)
            {
                if (isIntervalApplied)
                {
                    result.Add(new List<int> { interval[0], interval[1] });
                    continue;
                }

                if (left > interval[1])
                {
                    result.Add(new List<int> { interval[0], interval[1] });
                    continue;
                }

                left = Math.Min(left, interval[0]);

                if (right < interval[0])
                {
                    result.Add(new List<int> { left, right });
                    isIntervalApplied = true;
                    result.Add(new List<int> { interval[0], interval[1] });
                    continue;
                }

                right = Math.Max(right, interval[1]);
            }

            if (!isIntervalApplied)
            {
                result.Add(new List<int> { left, right });
            }


            int[][] arr = new int[result.Count][];
            for (int i = 0; i < result.Count; i++)
            {
                arr[i] = new[] { result[i][0], result[i][1] };
            }

            return arr;
        }

        public void Execute()
        {
            Insert(new[] { new int[2] { 1, 2 }, new int[2] { 3, 4 } }, new[] { 1, 9 });
            Insert(new[] { new int[2] { 1, 3 }, new int[2] { 6, 9 } }, new[] { 2, 5 });
            /*
             *Input: intervals = [[1,2],[3,5],[6,7],[8,10],[12,16]], newInterval = [4,8]
Output: [[1,2],[3,10],[12,16]]
             *
             */
            Insert(
                new[]
                {
                    new int[2] {1, 2}, new int[2] {3, 4}, new int[2] {6, 7}, new int[2] {8, 10}, new int[2] {12, 16}
                }, new[] { 4, 8 });

            throw new NotImplementedException();
        }
    }
}