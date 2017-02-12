using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LeetCode.Leets;

namespace LeetCode.LeetAgain
{
    class IncreasingTripletSln : ISolution
    {
        public bool IncreasingTriplet(int[] nums)
        {
            int small = Int32.MaxValue;
            int large = Int32.MaxValue;

            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] < small)
                {
                    small = nums[i];
                }
                else if (nums[i] < large)
                {
                    large = nums[i];
                }
                else
                {
                    return true;
                }
            }
            return false;
        }
        public void Execute()
        {
            throw new NotImplementedException();
        }
    }
}
