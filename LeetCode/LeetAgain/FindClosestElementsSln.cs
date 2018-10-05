using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode.LeetAgain
{
    class FindClosestElementsSln : ISolution
    {
        public IList<int> FindClosestElements(int[] arr, int k, int x)
        {
            if (x <= arr[0]) return arr.Take(k).ToArray();
            if (x >= arr[arr.Length - 1]) return arr.Skip(arr.Length - k).Take(k).ToArray();

            int[] result = new int[k];


            int startIndex = -1;
            int prev = arr[0];
            for (int i = 0; i < arr.Length; i++)
            {
                if (x > prev && x <= arr[i])
                {
                    startIndex = i;
                    break;
                }
                prev = arr[i];
            }

            if (arr[startIndex] != x)
            {
                if (Math.Abs(x - arr[startIndex]) > Math.Abs(x - arr[startIndex -1]))
                {
                    startIndex = startIndex - 1;
                }
            }


            int count = 0;
            int abs = Math.Abs(x - arr[startIndex]);
            result[count] = arr[startIndex];
            count++;
            int left = startIndex - 1;
            int right = startIndex + 1;
            int leftAbs = 0;
            int rightAbs = 0;
            while (count < k)
            {
                if (left < 0)
                {
                    leftAbs = int.MaxValue;
                }
                else
                {
                    leftAbs = Math.Abs(x - arr[left]);
                }
                if (right >= arr.Length)
                {
                    rightAbs = int.MaxValue;
                }
                else
                {
                    rightAbs = Math.Abs(x - arr[right]);
                }


                if (leftAbs <= rightAbs)
                {
                    result[count] = arr[left];
                    left--;
                    count++;
                    continue;
                }
                else
                {
                    result[count] = arr[right];
                    right++;
                    count++;
                    continue;
                }
            }

            Array.Sort(result);
            return result;
        }
        public void Execute()
        {
            var arr = FindClosestElements(new int[] { 0, 0, 1, 2, 3, 3, 4, 7, 7, 8 }, 3, 5);
            arr = FindClosestElements(new int[] { 1, 2, 3, 4, 5 }, 4, -1);
            arr = FindClosestElements(new int[] { 1, 2, 3, 4, 5 }, 4, 11);
        }
    }
}
