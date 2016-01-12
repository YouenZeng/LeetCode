using System;
using LeetCode.Leets;

namespace LeetCode.Algorithm
{


    public class PackProblem : ISolution
    {
        private const int Cost = 19;
        public void ZeroOnePack(int cost, int weight, ref int[] f)
        {
            for (int i = Cost - 1; i >= cost; i--)
            {
                f[i] = Math.Max(f[i], f[i - cost] + weight);
            }
        }

        public void Execute()
        {
            int[] f = new int[Cost];
            int[] costs = { 1, 2, 3, 4, 5, 1 };
            int[] weights = { 5, 4, 3, 2, 1, 100 };

            for (int i = 0; i < costs.Length; i++)
            {
                ZeroOnePack(costs[i], weights[i], ref f);
            }
        }
    }
}
