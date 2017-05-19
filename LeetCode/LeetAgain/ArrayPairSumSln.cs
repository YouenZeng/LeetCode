using System;

namespace LeetCode.LeetAgain
{
    public class ArrayPairSumSln : ISolution
    {
        public int ArrayPairSum(int[] nums)
        {
            //1. sort
            //2. sum odd index item
            Array.Sort(nums);
            int result = 0;
            for (int i = 0; i < nums.Length; i += 2)
            {
                result += nums[i];
            }
            return result;
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
        void Swap(int[] nums, int fromIndex, int toIndex)
        {
            int temp = nums[fromIndex];
            nums[fromIndex] = nums[toIndex];
            nums[toIndex] = temp;
        }

        public void Execute()
        {
            int[] arr = new[] { 1, 1 };
            QuickSort(arr, 0, arr.Length - 1);
        }
    }
}
