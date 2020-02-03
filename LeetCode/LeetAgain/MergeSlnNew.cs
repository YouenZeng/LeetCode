using System;

namespace LeetCode.LeetAgain
{
    class MergeSlnNew : ISolution
    {

        /*
Input: [[1,3],[2,6],[8,10],[15,18]]
Output: [[1,6],[8,10],[15,18]]
Explanation: Since intervals [1,3] and [2,6] overlaps, merge them into [1,6].
        */

        public int[][] Merge(int[][] intervals)
        {
            QuickSort(intervals, 0, intervals.GetLength(0) - 1);
            throw new NotImplementedException();
        }

        void QuickSort(int[][] nums, int fromIndex, int toIndex)
        {
            if (fromIndex < toIndex)
            {
                //partion
                int pivotIndex = Partition(nums, fromIndex, toIndex);

                QuickSort(nums, fromIndex, pivotIndex - 1);
                QuickSort(nums, pivotIndex + 1, toIndex);
            }
        }

        int Partition(int[][] nums, int left, int right)
        {
            int pivot = nums[left][0];
            int l = left + 1;
            int r = right;
            while (l <= r)
            {
                if (nums[l][0] < pivot && nums[r][0] > pivot)
                    Swap(nums, l--, r--);
                if (nums[l][0] >= pivot) l++;
                if (nums[r][0] <= pivot) r--;
            }

            Swap(nums, left, r);
            return r;
        }
        void Swap(int[][] nums, int fromIndex, int toIndex)
        {
            var temp = nums[fromIndex];
            nums[fromIndex] = nums[toIndex];
            nums[toIndex] = temp;
        }


        public void Execute()
        {
            var arr = new[] {
                new int[2] { 1, 3 },
                new int[2] { 2, 6 },
                new int[2] { 2, 8 },
                new int[2] { 8, 9 },
                new int[2] { 12, 18 }
            };

            Merge(arr);
        }
    }
}
