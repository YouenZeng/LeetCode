using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LeetCode.Leets;

namespace LeetCode.Infra
{
    public class AllSort : ISolution
    {

        public int Partition(int[] arr, int left, int right)
        {
            int pivot = arr[left];
            while (true)
            {
                while (arr[left] < pivot)
                    left++;

                while (arr[right] > pivot)
                    right--;

                if (left < right)
                {
                    int temp = arr[left];
                    arr[left] = arr[right];
                    arr[right] = temp;
                }
                else
                {
                    return right;
                }
            }
        }

        public void QuickSort(int[] arr, int left, int right)
        {
            if (left < right)
            {
                int pivot = Partition(arr, left, right);

                if (pivot > 1)
                    QuickSort(arr, left, pivot - 1);

                if (pivot + 1 < right)
                    QuickSort(arr, pivot + 1, right);
            }
        }


        public void Execute()
        {
            int[] arr = { 1, 2, 3, 4, 8, 7, 5, 6 };
            QuickSort(arr, 0, arr.Length - 1);
            Console.WriteLine(arr.Length);
        }
    }
}
