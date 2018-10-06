using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetCode.LeetAgain
{
    class FindClosestElementsSln : ISolution
    {
        public IList<int> FindClosestElements(int[] arr, int k, int x)
        {
            int start = 0;
            int end = arr.Length;
            while (start < end)
            {
                int mid = (end - start) / 2 + start;
                if (arr[mid] < x) start = mid + 1;
                else end = mid;
            }

            int left = start - 1;
            int right = end;
            while (k > 0)
            {
                if (left < 0)
                    right++;
                else if (right >= arr.Length)
                    left--;

                else if (Math.Abs(x - arr[left]) <= Math.Abs(x - arr[right]))
                {
                    left--;
                }
                else
                {
                    right++;
                }
                k--;
            }
            return arr.Skip(left+1).Take(right - left-1).ToArray();
        }
        public void Execute()
        {
            var arr = FindClosestElements(new int[] { 0, 0, 1, 3, 5, 6, 7, 8, 8 }, 2, 2);
            arr = FindClosestElements(new int[] { 1, 2, 3, 4, 5 }, 4, 3);
            arr = FindClosestElements(new int[] { 1, 2, 3, 4, 5 }, 4, 11);
        }
    }
}
