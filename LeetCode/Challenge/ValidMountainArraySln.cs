using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Challenge
{
    class ValidMountainArraySln : ISolution
    {
        public bool ValidMountainArray(int[] arr)
        {
            if (arr.Length < 3)
            {
                return false;
            }
            int left = 0;
            int right = arr.Length - 1;

            int upperBound = arr.Length - 1;
            while (left < upperBound && arr[left] < arr[left + 1])
            {
                left++;
            }
            while (right > 0 && arr[right] < arr[right - 1])
            {
                right--;
            }

            return left == right && left < upperBound && right > 0;
        }
        public void Execute()
        {
            Console.WriteLine(ValidMountainArray(new int[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 }));
            Console.WriteLine(ValidMountainArray(new int[] { 2, 1 }));
            Console.WriteLine(ValidMountainArray(new int[] { 1, 2, 1 }));
            Console.WriteLine(ValidMountainArray(new int[] { 1, 2, 2 }));
            Console.WriteLine(ValidMountainArray(new int[] { 1, 2, 3, 3, 2, 1 }));
            Console.WriteLine(ValidMountainArray(new int[] { 1, 2, 3, 4, 3, 1 }));
        }
    }
}
