namespace LeetCode.Challenge
{
    using System;
    using System.Linq;
    public class CanPartitionSln : ISolution
    {
        public bool CanPartition(int[] nums)
        {
            if (nums.Length == 1)
            {
                return false;
            }
            int sum = nums.ToList().Sum();
            if (sum % 2 == 1)
            {
                return false;
            }
            int target = sum / 2;
            Array.Sort(nums);

            bool[] dp = new bool[sum + 1];
            int sumTillNow = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                sumTillNow += nums[i];
                for (int j = sumTillNow; j >= 0; j--)
                {
                    if (dp[j])
                    {
                        dp[nums[i] + j] = true;
                    }
                    
                }

                dp[nums[i]] = true;
                if (dp[target] == true)
                {
                    return true;
                }
            }

            return false;
            // 1 5 7 11
            //11 10 7 7 7
        }
        public void Execute()
        {
            System.Console.WriteLine(CanPartition(new int[] { 2, 2, 3, 5 }));
            System.Console.WriteLine(CanPartition(new int[] { 1, 2, 2, 1 }));
            System.Console.WriteLine(CanPartition(new int[] { 2, 3, 4, 6, 14, 11 }));
            System.Console.WriteLine(CanPartition(new int[] { 1, 2 }));
            System.Console.WriteLine(CanPartition(new int[] { 1, 1 }));
        }
    }
}