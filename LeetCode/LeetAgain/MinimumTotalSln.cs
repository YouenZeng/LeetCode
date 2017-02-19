using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetCode.LeetAgain
{
    public class MinimumTotalSln : ISolution
    {
        public int MinimumTotal(IList<IList<int>> triangle)
        {
            int itemSize = triangle.Count;
            int[] memorize = triangle[itemSize - 1].ToArray();
            for (int layer = itemSize - 2; layer >= 0; layer--)
            {
                for (int i = 0; i <= layer; i++)
                {
                    memorize[i] = Math.Min(memorize[i], memorize[i + 1]) + triangle[layer][i];
                }
            }

            return memorize[0];
        }
        void ISolution.Execute()
        {
            IList<IList<int>> list = new List<IList<int>>()
            {
                new List<int>() { 2},
                new List<int>() { 3,4},
                new List<int>() { 6,5,7},
                new List<int>() { 4,1,8,3},
            };

            Console.WriteLine(MinimumTotal(list));
        }
    }
}