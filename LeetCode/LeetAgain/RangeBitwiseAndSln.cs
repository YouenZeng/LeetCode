using System;
using System.Collections.Generic;

namespace LeetCode.LeetAgain
{
    public class RangeBitwiseAndSln : ISolution
    {

        public int RangeBitwiseAnd(int m, int n)
        {
            if (m == 0)
            {
                return 0;
            }
            int moveFactor = 1;
            while (m != n)
            {
                m >>= 1;
                n >>= 1;
                moveFactor <<= 1;
            }
            return m * moveFactor;
        }




        //int FindHighestBit(int n)
        //{
        //    n |= (n >> 1);
        //    n |= (n >> 2);
        //    n |= (n >> 4);
        //    n |= (n >> 8);
        //    n |= (n >> 16);
        //    return n - (n >> 1);
        //}

        //int FindRoot(int n)
        //{
        //    int num = 0;
        //    while (n > 0)
        //    {
        //        n = n >> 1;
        //        num++;
        //    }
        //    return num;
        //}

        public void Execute()
        {
            RangeBitwiseAnd(112313212, 112313213);
        }
    }
}
