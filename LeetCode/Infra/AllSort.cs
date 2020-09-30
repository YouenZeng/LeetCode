using System;

namespace LeetCode.Infra
{
    public class AllSort : ISolution
    {
        void QuickSort(int[] arr, int start, int end)
        {
            if (start < end)
            {
                int pivot = Partition2(arr, start, end);
                QuickSort(arr, start, pivot - 1);
                QuickSort(arr, pivot + 1, end);
            }
        }

        int Partition(int[] arr, int start, int end)
        {
            int mid = (start + end) / 2;

            while (true)
            {
                while (arr[start] < arr[mid])
                    start++;
                while (arr[end] > arr[mid])
                    end--;

                if (start < end)
                    Swap(arr, start, end);
                else
                {
                    return start;
                }
            }
        }

        int Partition2(int[] arr, int start, int end)
        {
            int pivot = arr[end];

            for (int i = start; i < end; i++)
            {
                if (arr[i] < pivot)
                {
                    Swap(arr, start, i);
                    start++;
                }
            }

            Swap(arr, start, end);
            return start;
        }

        int Partition3(int[] nums, int left, int right)
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
        private void Swap(int[] arr, int from, int to)
        {
            var t = arr[to];
            arr[to] = arr[from];
            arr[from] = t;
        }

        public void Execute()
        {
            int[] arr = {1, 2, 3, 4, 8, 7, 5, 6};
            QuickSort(arr, 0, arr.Length - 1);
            Console.WriteLine(arr.Length);
        }
    }
}