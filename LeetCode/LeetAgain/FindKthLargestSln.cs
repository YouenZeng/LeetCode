using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using LeetCode.Leets;

namespace LeetCode.LeetAgain
{
    class FindKthLargestSln : ISolution
    {
        public int FindKthLargest(int[] nums, int k)
        {
            //            QuickSort(nums,0,nums.Length-1);
            //            return nums[k-1];

            int start = 0;
            int end = nums.Length - 1;

            while (true)
            {
                int position = Partition(nums, start, end);

                if (position == k - 1) return nums[k - 1];
                if (position > k - 1)
                {
                    end = position - 1;
                }
                else
                {
                    start = position + 1;
                }
            }
        }


        void QuickSort(int[] nums, int fromIndex, int toIndex)
        {

            if (fromIndex < toIndex)
            {
                //partion
                int pivotIndex = Partition(nums, fromIndex, toIndex);

                QuickSort(nums, fromIndex, pivotIndex - 1);
                QuickSort(nums, pivotIndex + 1, toIndex);

            }
        }

        int Partition(int[] nums, int left, int right)
        {
            int pivot = nums[left];
            int l = left + 1;
            int r = right;
            while (l <= r)
            {
                if (nums[l] < pivot && nums[r] > pivot)
                    Swap(nums, l--, r--);
                if (nums[l] >= pivot) l++;
                if (nums[r] <= pivot) r--;
            }

            Swap(nums, left, r);
            return r;
        }
        //int Partition(int[] nums, int fromIndex, int toIndex)
        //{
        //    int pivot = nums[toIndex];
        //    int currentPivotIndex = fromIndex;

        //    for (int i = fromIndex; i < toIndex; i++)
        //    {
        //        if (nums[i] >= pivot)
        //        {
        //            Swap(nums, i, currentPivotIndex);
        //            currentPivotIndex++;
        //        }
        //    }
        //    Swap(nums, currentPivotIndex, toIndex);
        //    return currentPivotIndex;
        //}

        void Swap(int[] nums, int fromIndex, int toIndex)
        {
            int temp = nums[fromIndex];
            nums[fromIndex] = nums[toIndex];
            nums[toIndex] = temp;
        }

        public void Execute()
        {
            int[] arr = { 1 ,2,3,4,6,78,33,2,22};
            Console.WriteLine(FindKthLargest(arr, 4));
            ;
        }
    }
}
