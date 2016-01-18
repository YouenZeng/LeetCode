using System.Collections.Generic;

namespace LeetCode.Leets
{
    class TwoSumSln : ISolution
    {
        public int[] TwoSum(int[] nums, int target)
        {
            int[] result = new int[2];

            Dictionary<int, int> keyDict = new Dictionary<int, int>();
            for (int i = 0; i < nums.Length; i++)
            {
                int targetKey = target - nums[i];
                if (keyDict.ContainsKey(targetKey))
                {
                    result[0] = keyDict[targetKey] + 1;
                    result[1] = i + 1;
                    return result;
                }
                if (keyDict.ContainsKey(nums[i]) == false)
                {
                    keyDict.Add(nums[i], i);
                }
            }
            return result;
        }
        public void Execute()
        {
            int[] arr = new[] { -3,4,3,90};
            TwoSum(arr, 0);
        }
    }
}
