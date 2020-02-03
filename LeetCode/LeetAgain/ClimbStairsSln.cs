using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.LeetAgain
{
    internal class ClimbStairsSln : ISolution
    {

        public int ClimbStairs(int n)
        {
            int result = 1;
            int prev = 1;
            int pPrev = 1;
            for (int i = 1; i < n; i++)
            {
                result = prev + pPrev;
                pPrev = prev;
                prev = result;
            }


            return result;
        }

        //int ClimbWrapper(int n, int[] memo)
        //{
        //    if (memo[n] != 0) return memo[n];

        //    if (n <= 2)
        //    {
        //        memo[n] = n;
        //        return n;
        //    }

        //    memo[n] = ClimbWrapper(n - 2, memo) + ClimbWrapper(n - 1, memo);
        //    return memo[n];

        //}

        public void Execute()
        {
            Console.WriteLine(ClimbStairs(44));
        }
    }
}
