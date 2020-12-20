using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Challenge
{
    class KthFactorSln : ISolution
    {
        public int KthFactor(int n, int k)
        {
            int halfFacCount = 0;
            int root = (int)Math.Pow(n, 0.5);
            Stack<int> stack = new Stack<int>();
            Stack<int> stack2 = new Stack<int>();
            for (int i = 1; i <= root; i++)
            {
                if (n % i == 0)
                {
                    stack.Push(i);
                    halfFacCount++;
                    if (i != n / i)
                    {
                        stack2.Push(n / i);
                    }

                }
                if (halfFacCount == k)
                {
                    return i;
                }
            }

            if (k > (stack.Count + stack2.Count))
            {
                return -1;
            }

            int c = k - stack.Count;
            int result = -1;
            while (c > 0)
            {
                result = stack2.Pop();
                c--;
            }
            return result;

        }
        public void Execute()
        {
            Console.WriteLine(KthFactor(12, 3));
            Console.WriteLine(KthFactor(7, 2));
            Console.WriteLine(KthFactor(4, 4));
            Console.WriteLine(KthFactor(4, 3));
            Console.WriteLine(KthFactor(1, 1));
            Console.WriteLine(KthFactor(1000, 3));
        }
    }
}
