using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.LeetAgain
{
    class MinSwapSln : ISolution
    {
        public int MinSwap(int[] A, int[] B)
        {
            //TODO
            throw new NotImplementedException();
        }

        private void Swap(int[] A, int[] B, int index)
        {
            int t = A[index];
            A[index] = B[index];
            B[index] = t;
        }
        public void Execute()
        {
            MinSwap(new int[] { 3, 3, 8, 9, 10 }, new int[] { 1, 7, 4, 6, 8 });
        }
    }
}
