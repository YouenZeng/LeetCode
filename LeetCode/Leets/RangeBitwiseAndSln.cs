using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Leets
{
    class RangeBitwiseAndSln:ISolution
    {
        public int RangeBitwiseAnd(int m, int n)
        {
            int moveFactor = 1;
            while (m != n)
            {
                m >>= 1;
                n >>= 1;
                moveFactor <<= 1;
            }
            return m * moveFactor;
        }
        public void Execute()
        {
            throw new NotImplementedException();
        }
    }
}
