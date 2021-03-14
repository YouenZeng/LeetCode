using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Challenge
{
    class BrokenCalcSln : ISolution
    {
        public int BrokenCalc(int X, int Y)
        {
            if (X >= Y)
            {
                return X - Y;
            }

            if (Y % 2 == 0)
            {
                return 1 + BrokenCalc(X, Y / 2);
            }

            return Math.Min(1 + BrokenCalc(2 * X, Y), 1 + BrokenCalc(X, Y + 1));
        }

        public void Execute()
        {
          int x =  BrokenCalc(1, 1000000000);
        }
    }
}