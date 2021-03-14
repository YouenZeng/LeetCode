using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace LeetCode.Algorithm
{
    class NumArray
    {
        private readonly int[] tree;
        private readonly int n;

        public NumArray(int[] arr)
        {
            if (arr.Length > 0)
            {
                n = arr.Length;
                tree = new int[2 * n];
                Build(arr);
            }
        }

        private void Build(int[] arr)
        {
            for (int i = n, j = 0; i < 2 * n; i++, j++)
            {
                tree[i] = arr[j];
            }

            for (int i = n - 1; i > 0; i--)
            {
                tree[i] = tree[2 * i] + tree[2 * i + 1];
            }
        }

        public void Update(int index, int val)
        {
            index = index + n;
            tree[index] = val;

            while (index > 0)
            {
                int left = index;
                int right = index;

                if (index % 2 == 0)
                {
                    right = index + 1;
                }
                else
                {
                    left = index - 1;
                }

                tree[index / 2] = tree[left] + tree[right];
                index /= 2;
            }
        }

        public int SumRange(int left, int right)
        {
            left += n;
            right += n;

            int sum = 0;
            while (left <= right)
            {
                if (left % 2 == 1)
                {
                    sum += tree[left];
                    left++;
                }

                if (right % 2 == 0)
                {
                    sum += tree[right];
                    right--;
                }

                left /= 2;
                right /= 2;
            }

            return sum;
        }
    }
}