using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Lof
{
    class QqqqqqqqqqqqqquickSort : ISolution
    {
        public void QuickSort(int[] nums, int start, int end)
        {
            if (start < end)
            {
                var p = Partition(nums, start, end);
                QuickSort(nums, start, p - 1);
                QuickSort(nums, p + 1, end);
            }
        }

        private int Partition(int[] nums, int start, int end)
        {
            var pivot = nums[end];
            int mark = start;//-1

            for (int i = start; i < end; i++) //end 是pivot位，不用处理
            {
                if (nums[i] <= pivot)
                {
                    Swap(nums, mark, i);
                    mark++;
                    
                }
            }

            Swap(nums, mark, end);
            return mark;
        }
        private void Swap(int[] nums, int from, int to)
        {
            int t = nums[from];
            nums[from] = nums[to];
            nums[to] = t;
        }

        public void Execute()
        {
            var arr = new int[] { 3, 2, 1, 0, 5, 6, 7, 5, 11, 4, 200 };
            QuickSort(arr, 0, arr.Length - 1);
            Console.WriteLine(String.Join(' ', arr));
        }
    }
}
