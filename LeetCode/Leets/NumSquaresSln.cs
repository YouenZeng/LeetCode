using System;

namespace LeetCode.Leets
{
    class NumSquaresSln : ISolution
    {
        public int NumSquares(int n)
        {
            int[] cache = new int[n];


            for (int i = 1; i < n; i++)
            {
                double root = Math.Sqrt(n);
                for (int j = (int)root; j > 0; j--)
                {

                }
            }

            throw  new NotImplementedException();
        }
        public void Execute()
        {
            throw new NotImplementedException();
        }
    }
}
