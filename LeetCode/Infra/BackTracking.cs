using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Infra
{
    class BackTracking : ISolution
    {
        public void Execute()
        {
            GenerateTree(4);
        }

        public void GenerateTree(int n)
        {
            int[] x = new int[n];
            for (int i = 0; i < n; i++)
            {
                x[i] = i + 1;
            }
            BackTrack(1, n, x);
        }

        void BackTrack(int t, int n, int[] x)
        {
            if (t >= n) Console.WriteLine(string.Join(",", x));

            else
            {
                for (int i = t; i <= n; i++)
                {
                    Swap(x, t, i);
                    BackTrack(t + 1, n, x);
                    Swap(x, t, i);
                }
            }
        }

        void Swap(int[] x, int index1, int index2)
        {
            if (index1 == index2) return;

            Console.WriteLine($"swap {index1} - {index2}");
            int t = x[index1 - 1];
            x[index1 - 1] = x[index2 - 1];
            x[index2 - 1] = t;
        }
    }
}
