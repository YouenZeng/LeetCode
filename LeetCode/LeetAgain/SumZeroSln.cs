using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.LeetAgain
{
    class SumZeroSln : ISolution
    {
        public int[] SumZero(int n)
        {
            int[] result = new int[n];
            int sum = 0;
            for (int i = 1; i < n-1; i++)
            {
                result[i] = i;
                sum += i;
            }
            result[0] = sum * -1;
            return result;
        }
        public void Execute()
        {
            throw new NotImplementedException();
        }
    }
}
