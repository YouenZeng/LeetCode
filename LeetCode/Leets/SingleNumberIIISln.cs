using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Leets
{
    class SingleNumberIIISln:ISolution
    {
        public int[] SingleNumber(int[] nums)
        {
            // Pass 1 : 
            // Get the XOR of the two numbers we need to find
            int diff = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                diff ^= nums[i];
            }
          
            // Get its last set bit
            diff &= -diff;

            // Pass 2 :
            int[] rets = { 0, 0 }; // this array stores the two numbers we will return
            for (int i = 0; i < nums.Length; i++)
            {
                if ((nums[i] & diff) == 0) // the bit is not set
                {
                    rets[0] ^= nums[i];
                }
                else // the bit is set
                {
                    rets[1] ^= nums[i];
                }
            }
            return rets;
        }
        public void Execute()
        {
            int[] nums = {1,24,4,5,5,4,1,4566};
            Console.WriteLine(SingleNumber(nums));
        }
    }
}
