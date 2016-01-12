using System;

namespace LeetCode.Leets
{
    class ClimbingStairsSln : ISolution
    {
        public int ClimbStairs(int n)
        {
            if (n == 0) return 0;
            if (n == 1) return 1;
            if (n == 2) return 2;

            int oneStepBefore = 1;
            int twoStepBefore = 2;

            int waysCount = 0;

            for (int i = 2; i <= n; i++)
            {
                waysCount = oneStepBefore + twoStepBefore;
                oneStepBefore = twoStepBefore;
                twoStepBefore = waysCount;
            }
            return waysCount;
        }

        public int Climb(int n)
        {
            var arr = new int[n + 1];
            if (n == 0) return 1;
            if (n == 1) return 1;

            arr[0] = 1;
            arr[1] = 1;
            for (int i = 2; i <= n; i++)
            {
                arr[i] = arr[i - 1] + arr[i - 2];
            }
            return arr[n];
        }
        public void Execute()
        {
            Console.WriteLine(ClimbStairs(3));
        }
    }
}
