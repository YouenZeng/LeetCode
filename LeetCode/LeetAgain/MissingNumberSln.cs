using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.LeetAgain
{
    class MissingNumberSln : ISolution
    {
        public int MissingNumber(int[] nums)
        {
            int t = 0;
            int i = 0;
            for (i = 0; i < nums.Length; i++)
            {
                t = t ^ nums[i] ^ i;
            }

            return t ^ i;
        }
        public void Execute()
        {
            throw new NotImplementedException();
        }
    }
}
