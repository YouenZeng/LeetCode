using System;

namespace LeetCode.LeetAgain
{
    public class MinCostClimbingStairsSln : ISolution
    {
        public int MinCostClimbingStairs(int[] cost)
        {
            if (cost.Length == 1) return cost[0];
            if (cost.Length == 1) return Math.Max(cost[0], cost[1]);
            int prevStep = cost[1];
            int prevPrevStep = cost[0];

            for (int i = 2; i < cost.Length; i++)
            {
                int tmp = prevStep;
                prevStep = Math.Min(cost[i] + prevStep, cost[i] + prevPrevStep);
                prevPrevStep = tmp;
            }
            return Math.Min(prevStep, prevPrevStep);
        }
        void ISolution.Execute()
        {
            MinCostClimbingStairs(new int[] { 1, 100,100, 1, 1, 1, 100, 1, 1, 100, 1 });
            MinCostClimbingStairs(new int[] { 10,15,20 });
        }
    }
}