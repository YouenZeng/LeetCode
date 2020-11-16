using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using LeetCode.LeetAgain;

namespace LeetCode.Infra
{
    public class HeapSort2
    {
        public void Heapify(int[] arr, int idx)
        {
            int l = idx * 2 + 1;
            int r = idx + 1;



        }

        public void Sort(int[] arr)
        {
            var length = arr.Length;
            int mid = (length - 1) / 2;


            for (int i = mid; i >= 0; i--)
            {
                Heapify(arr, i);
            }
        }

        public void Test()
        {
            Sort(new int[] {3, 1, 3, 11, 22, 33, 44, 0, 2});
        }
    }
}