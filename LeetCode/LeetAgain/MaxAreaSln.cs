using System;

namespace LeetCode.LeetAgain
{
    class MaxAreaSln : ISolution
    {
        public int MaxArea(int[] height)
        {
            int i = 0;
            int j = height.Length - 1;
            int result = 0;
            while (i < j)
            {
                result = Math.Max(result, (j - i) * Math.Min(height[i], height[j]));
                if (height[i] < height[j]) i++;
                else j--;
            }

            return result;
        }
        public void Execute()
        {
            MaxArea(new int[] { 1, 2, 1, 1, 4, 5, 1, 4, 4, 5, 7 });
        }
    }
}
