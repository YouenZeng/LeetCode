using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.LeetAgain
{
    class PlusOneSln : ISolution
    {
        public int[] PlusOne(int[] digits)
        {
            int prevPlus = 0;
            for (int i = digits.Length - 1; i >= 0; i--)
            {
                if (digits[i] + 1 <= 9)
                {
                    digits[i] = digits[i] + 1;
                    return digits;
                }
                else
                {
                    digits[i] = digits[i] + 1 - 10;
                    prevPlus = 1;
                }
            }

            if (prevPlus == 1)
            {
                int[] result = new int[digits.Length + 1];
                for (int i = digits.Length - 1; i >= 0; i--)
                {
                    result[i + 1] = digits[i];
                }
                result[0] = 1;
                return result;
            }
            return digits;
        }
        public void Execute()
        {
            PlusOne(new int[] { 1, 3, 4 });
            PlusOne(new int[] { 1, 3, 9 });

            PlusOne(new int[] { 9, 9, 9,9 });
        }
    }
}
