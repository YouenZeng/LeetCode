using System;
using System.Diagnostics;

namespace LeetCode.LeetAgain
{
    class ReverseBitsSln : ISolution
    {
        public uint ReverseBits(uint n)
        {
            uint result = 0;
            uint one = 1;
            for (int i = 0; i < 32; i++)
            {
                if (n % 2 == 1)
                {
                    result += (one << (31 - i));
                }
                n = n / 2;
            }
            return result;
        }
        public void Execute()
        {
            Debug.Assert(ReverseBits(1) == 964176192);
        }
    }
}
