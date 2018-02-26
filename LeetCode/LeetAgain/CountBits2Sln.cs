using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.LeetAgain
{
    class CountBits2Sln : ISolution
    {
        public int[] CountBits(int num)
        {
            int[] result = new int[num + 1];
            if (num == 0) return result;
            result[1] = 1;
            if (num == 1) return result;

            int currentIndex = 2;
            int factor = 2;
            while (currentIndex <= num)
            {
                if (currentIndex / factor > 1)
                {
                    factor <<= 1;
                    result[currentIndex] = 1;
                }
                else
                {
                    result[currentIndex] = 1 + result[currentIndex % factor];
                }
                currentIndex++;
            }

            return result;
        }
        public void Execute()
        {
            CountBits(15);
        }
    }
}
