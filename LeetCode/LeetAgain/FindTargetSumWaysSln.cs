namespace LeetCode.LeetAgain
{
    public class FindTargetSumWaysSln : ISolution
    {
        private int count;
        public int FindTargetSumWays(int[] nums, int S)
        {
            int[,] memo = new int[nums.Length, 2001];

            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = 0; j < 2001; j++)
                {
                    memo[i, j] = int.MinValue;
                }
            }

            int result = FindTargetsFromWithMemo(nums, S, 0, 0, memo);
            return result;
        }

        private void FindTargetsFrom(int[] nums, int S, int currentSum, int currentIndex)
        {
            if (currentIndex == nums.Length)
            {
                System.Diagnostics.Debug.WriteLine($"reach end currentIndex {currentIndex}, current sum {currentSum}");
                if (S == currentSum)
                {
                    count++;
                }
            }
            else
            {
                FindTargetsFrom(nums, S, currentSum - nums[currentIndex], currentIndex + 1);
                FindTargetsFrom(nums, S, currentSum + nums[currentIndex], currentIndex + 1);
            }
        }

        private int FindTargetsFromWithMemo(int[] nums, int S, int currentSum, int currentIndex, int[,] memo)
        {
            if (currentIndex == nums.Length)
            {
                System.Diagnostics.Debug.WriteLine($"reach end currentIndex {currentIndex}, current sum {currentSum}");
                if (S == currentSum)
                {
                    return 1;
                }
                else
                {
                    return 0;
                }
            }
            else
            {
                if (memo[currentIndex, currentSum + 1000] != int.MinValue)
                {
                    return memo[currentIndex, currentSum + 1000];
                }
                else
                {
                    int sub = FindTargetsFromWithMemo(nums, S, currentSum - nums[currentIndex], currentIndex + 1, memo);
                    int add = FindTargetsFromWithMemo(nums, S, currentSum + nums[currentIndex], currentIndex + 1, memo);
                    memo[currentIndex, currentSum + 1000] = add + sub;
                    return memo[currentIndex, currentSum + 1000];
                }
            }
        }


        public void Execute()
        {
            FindTargetSumWays(new int[] { 1, 1, 1, 1, 1 }, 3);
        }
    }
}
