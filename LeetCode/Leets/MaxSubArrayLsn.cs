namespace LeetCode.Leets
{
    class MaxSubArrayLsn:ISolution
    {
        public int MaxSubArray(int[] nums)
        {
            int totalSum = nums[0];
            int currentMax = nums[0];
            for (int i = 1; i < nums.Length; i++)
            {
                if (totalSum < 0)
                    totalSum = nums[i];
                else
                    totalSum = totalSum + nums[i];

                if (totalSum > currentMax)
                    currentMax = totalSum;
            }
            return currentMax;
        }
        public void Execute()
        {
            int[] arr = {-2,1,-3,4,-1,2,1,-5,4};
            MaxSubArray(arr);
        }
    }
}
