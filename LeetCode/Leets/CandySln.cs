using System;
using System.Linq;

namespace LeetCode.Leets
{
    public class CandySln : ISolution
    {
        public int Candy(int[] ratings)
        {
            if (ratings.Length <= 1)
                return ratings.Length;

            int[] candyArr = new int[ratings.Length];
            int previousIndex = 0;

            for (int i = 1; i < ratings.Length; i++)
            {
                //左边大于右边
                if (ratings[i] > ratings[previousIndex])
                {
                    candyArr[i] = candyArr[i] + 1;
                }
                //右边大于左边,则需要重新遍历
                else
                {
                }
                previousIndex = i;
            }
            return candyArr.Sum(c => c);
        }
        public void Execute()
        {
            int[] ratings = { 3, 1 };
            Console.WriteLine(Candy(ratings));
        }
    }
}
