using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Leets
{
    class QuickSortSln : ISolution
    {
        private  void Sort(int[] numbers, int left, int right)
        {
            if (left < right)
            {
                int middle = numbers[(left + right) / 2];
                int i = left - 1;
                int j = right + 1;
                while (true)
                {
                    while (numbers[++i] > middle)
                    {
                    }

                    while (numbers[--j] < middle)
                    {
                    }

                    if (i >= j)
                        break;

                    Swap(numbers, i, j);
                }

                Sort(numbers, left, i - 1);
                Sort(numbers, j + 1, right);
            }
        }

        private  void Swap(int[] numbers, int i, int j)
        {
            int number = numbers[i];
            numbers[i] = numbers[j];
            numbers[j] = number;
        }

        public  int GetMedian(int[] nums, int i, int j)
        {
            int length = j - i;
            int first = nums[i];
            int last = nums[j];
            int mid = nums[length / 2];

            int median = Math.Max(Math.Min(first, last), Math.Min(Math.Max(first, last), mid));

            if (median == mid) return length / 2;
            if (median == first) return i;
            return j;
        }
        public void Execute()
        {
            int[] nums = { 2, 3, 4, 5, 69, 7, 6, 1, 10, 67, 45, 34, 12, 55, 88, 8, 34, 67 };
            Sort(nums, 0, nums.Length - 1);
        }
    }
}
