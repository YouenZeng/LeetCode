using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LeetCode.LeetAgain
{
    public class NumArray
    {
        readonly int[] _numsInternal;

        public NumArray(int[] nums)
        {
            int numLength = nums.Length;
            for (int i = 1; i < numLength; i++)
            {
                nums[i] += nums[i - 1];
            }
            _numsInternal = nums;
        }

        public int SumRange(int i, int j)
        {
            if (i == 0)
                return _numsInternal[j];
            return _numsInternal[j] - _numsInternal[i - 1];
        }

    }
}
