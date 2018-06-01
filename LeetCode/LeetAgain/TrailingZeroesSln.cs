using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.LeetAgain
{
    class TrailingZeroesSln : ISolution
    {
        public int TrailingZeroes(int n)
        {
            int result = 0;
            while (n >= 5)
            {
                result += n / 5;
                n =  n/5;
            }
            return result;
        }
        public void Execute()
        {
            throw new NotImplementedException();
        }
    }
}
