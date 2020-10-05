using System;
using System.Linq;

namespace LeetCode.LeetAgain
{
    public class CandySln : ISolution
    {
        public int Candy(int[] ratings)
        {
            int[] candies = new int[ratings.Length];
            candies[0] = 1;
            for (int i = 1; i < ratings.Length; i++)
            {
                candies[i] = ratings[i] > ratings[i - 1] ? candies[i - 1] + 1 : 1;
            }

            for (int i = ratings.Length - 2; i >= 0; i--)
            {
                int t = ratings[i] > ratings[i + 1] ? candies[i + 1] + 1 : 1;
                candies[i] = Math.Max(t, candies[i]);
            }

            return candies.Sum();
        }

        public void Execute()
        {
        }
    }
}