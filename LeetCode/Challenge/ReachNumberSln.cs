using System;

namespace LeetCode.Challenge
{
    class ReachNumberSln : ISolution
    {
        public int ReachNumber(int target)
        {
            target = Math.Abs(target);
            int sum = 0;
            int seed = 0;
            while (sum < target)
            {
                seed++;
                sum += seed;
                
            }

            if (sum == target)
            {
                return seed;
            }

            int gap = sum - target;
            if (gap % 2 == 0)
            {
                return seed;
            }

            if ((gap + (seed + 1)) % 2 == 0)
            {
                return seed + 1;
            }
            return seed + 2;
        }
        public void Execute()
        {
            Console.WriteLine(ReachNumber(3));
            Console.WriteLine(ReachNumber(2));
            Console.WriteLine(ReachNumber(5));
        }
    }
}
