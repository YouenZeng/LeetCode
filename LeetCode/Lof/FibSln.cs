using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Lof
{
    class FibSln : ISolution
    {
        public int Fib(int n)
        {
            if (n <= 1)
            {
                return n;
            }
            int prev = 1;
            int pPrev = 0;

            for (int i = 2; i <= n; i++)
            {
                prev = (pPrev + prev) % 1000000007;
                pPrev = (prev-pPrev);
            }
            return prev;
        }
        public void Execute()
        {

            Console.WriteLine(Fib(3));
            Console.WriteLine(Fib(4));
            Console.WriteLine(Fib(5));
        }
    }
}
