using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LeetCode.LeetAgain
{
    public class NumArray
    {
        readonly int[] _numsInternal;
        readonly int[] _nums;
        public NumArray(int[] nums)
        {
            _nums = nums;

            int numLength = nums.Length;
            _numsInternal = new int[numLength];
            Array.Copy(nums, _numsInternal, numLength);
            for (int i = 1; i < numLength; i++)
            {
                _numsInternal[i] += _numsInternal[i - 1];
            }
        }

        public void Update(int i, int val)
        {

            int diff = val - _nums[i];
            _nums[i] = val;
            for (int j = i; j < _numsInternal.Length; j++)
            {
                _numsInternal[j] += diff;
            }
        }

        public int SumRange(int i, int j)
        {
            if (i == 0)
                return _numsInternal[j];
            return _numsInternal[j] - _numsInternal[i - 1];
        }
    }
}
