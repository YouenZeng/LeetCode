using System;

namespace LeetCode.Leets
{
    class TrailingZeroesSln : ISolution
    {
        public int TrailingZeroes(int n)
        {
            int sum = 0;
            int tmp = 0;
            while (n / 5 > 0)
            {
                tmp = n / 5;
                sum += tmp;
                n = tmp;
            }
            return sum;
        }
        public void Execute()
        {
            throw new NotImplementedException();
        }
    }
}
