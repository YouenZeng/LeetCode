namespace LeetCode.LeetAgain
{
    class MinPatchesSln : ISolution
    {
        public int MinPatches(int[] nums, int n)
        {
            //greedy
            long currentFixed = 0;
            int result = 0;
            int currentIndex = 0;
            int totalCount = nums.Length;
            while (currentFixed < n)
            {
                if (currentIndex < totalCount && nums[currentIndex] <= (currentFixed + 1))
                {
                    currentFixed += nums[currentIndex];
                    currentIndex++;
                }
                else
                {
                    currentFixed += currentFixed + 1;
                    result++;
                }
            }

            return result;
        }

        public void Execute()
        {
            MinPatches( new[] {  5, 10 }, 20);
        }
    }
}