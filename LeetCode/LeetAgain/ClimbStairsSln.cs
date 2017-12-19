using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.LeetAgain
{
    class ClimbStairsSln : ISolution
    {

        public int ClimbStairs(int n)
        {
            if (n <= 2) return n;

            int stepsBeforeOne = 2;
            int stepsBeforeTwo = 1;
            int all = 0;
            for (int i = 2; i < n; i++)
            {
                all = stepsBeforeOne + stepsBeforeTwo;
                stepsBeforeTwo = stepsBeforeOne;
                stepsBeforeOne = all;
            }
            return all;
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
