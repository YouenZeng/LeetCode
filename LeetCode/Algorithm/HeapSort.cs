using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Algorithm
{
    class HeapSort
    {
        private int[] data;
        private int size;

        public HeapSort(int size)
        {
            data = new int[size];
            this.size = size;
        }

        public HeapSort(int[] data)
        {
            this.data = data;
            size = data.Length - 1;
        }

        private void Heapify(int i)
        {
            int left = i * 2 + 1;
            int right = i * 2 + 2;

            int largest = i;
            if (left > size) return;
            if (data[left] > data[i])
            {
                largest = left;
            }

            if (right <= size && data[right] > data[largest])
            {
                largest = right;
            }

            if (largest != i)
            {
                int temp = data[largest];
                data[largest] = data[i];
                data[i] = temp;
                Heapify(largest);
            }
        }

        public void BuildHeap()
        {
            int mid = (size - 1) / 2;
            for (int i = mid; i >= 0; i--)
            {
                Heapify(i);
            }
        }

        public void Sort()
        {

        }

    }
}