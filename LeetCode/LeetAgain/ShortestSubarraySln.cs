using System;
using System.Collections.Generic;

namespace LeetCode.LeetAgain
{
    internal class ShortestSubarraySln : ISolution
    {
        public int ShortestSubarray(int[] A, int K)
        {
            int inputLength = A.Length;
            int result = inputLength + 1;
            int[] B = new int[result + 1];
            for (int i = 0; i < inputLength; i++)
            {
                B[i + 1] = B[i] + A[i];
            }
            LinkedList<int> link = new LinkedList<int>();

            for (int i = 0; i < inputLength + 1; i++)
            {
                while (link.Count > 0 && B[i] <= B[link.Last.Value])
                {
                    link.RemoveLast();
                }

                while (link.Count > 0 && B[i] - B[link.First.Value] >= K)
                {
                    result = Math.Min(result, i - link.First.Value);
                    link.RemoveFirst();
                }

                link.AddLast(i);
            }

            return result <= inputLength ? result : -1;
        }

        public void Execute()
        {
            ShortestSubarray(new int[] { 2, 3, -3, 3, 2, -20, 5 }, 6);
        }
    }
}
