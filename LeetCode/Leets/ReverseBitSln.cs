using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Leets
{
    class ReverseBitSln:ISolution
    {
        public uint reverseBits(uint n)
        {
            uint result = 0;
            for (int i = 0; i < 32; i++)
            {
                result += n & 1;
                n = n >> 1;
                if (i < 31)
                {
                    result = result << 1;
                }
            }
            return result;
        }
        public void Execute()
        {
            reverseBits(7);
        }
    }
}
