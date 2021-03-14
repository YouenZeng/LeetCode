using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Challenge
{
    class CheckPowersOfThreeSln : ISolution
    {
        public bool CheckPowersOfThree(int n)
        {
            List<int> possible = new List<int>();
            int max = 10000000;
            int seed = 1;
            while (seed < max)
            {
                possible.Add(seed);
                seed *= 3;
            }
            possible.Reverse();

            foreach (int p in possible)
            {
                if (p <= n)
                {
                    n -= p;
                }
            }

            return n == 0;
        }

        public void Execute()
        {
            Console.WriteLine(CheckPowersOfThree(1));
            Console.WriteLine(CheckPowersOfThree(21));
            Console.WriteLine(CheckPowersOfThree(12));
            Console.WriteLine(CheckPowersOfThree(13));
            Console.WriteLine(CheckPowersOfThree(9));
            Console.WriteLine(CheckPowersOfThree(28));
            Console.WriteLine(CheckPowersOfThree(2));
        }
    }
}