using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode.LeetAgain
{
    class MinStepsSln : ISolution
    {
        public int MinStepsGeedy(int n)
        {
            int result = 0;
            for (int i = 2; i <= n; i++)
            {
                while(n % i == 0)
                {
                    result += i;
                    n /= i;
                }
            }
            return result;
        }
        public int MinSteps(int n)
        {
            if (n == 1) return 0;

            int square_root = (int)Math.Sqrt(n) + 1;
            List<int> root = FindRoots(n);
            if (root.Count == 0)
            {
                return n;
            }
            int maxRoot = root.Max();
            return MinSteps(maxRoot) + n / maxRoot;
        }

        List<int> FindRoots(int n)
        {
            int square_root = (int)Math.Sqrt(n) + 1;
            List<int> root = new List<int>();
            for (int i = 2; i < square_root; i++)
            {
                if (n % i == 0 && i * i != n)
                {
                    root.Add(i);
                    root.Add(n / i);
                }
                if (n % i == 0 && i * i == n)
                {
                    root.Add(i);
                }
            }
            return root;
        }
        public void Execute()
        {
            Console.WriteLine(MinSteps(32));
            Console.WriteLine(MinSteps(1));
            Console.WriteLine(MinSteps(21));
            Console.WriteLine(MinSteps(33));
            Console.WriteLine(MinSteps(25));
        }
    }
}
