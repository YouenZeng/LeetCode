using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetCode.Challenge
{
    class BasicCalculatorIISln : ISolution
    {
        public int Calculate(string s)
        {
            //3-5+2*3/2+2
            Stack<int> stack = new Stack<int>();
            s = s.Replace(" ", "");
            s = s + "+";
            int start = 0;
            int current = 0;
            int end = s.Length;

            char op = '+';
            while (current < end)
            {
                if (!char.IsNumber(s[current]))
                {
                    int op2 = Convert.ToInt32(s.Substring(start, current - start));
                    if (op == '-')
                    {
                        stack.Push(op2 * -1);
                    }
                    else if (op == '+')
                    {
                        stack.Push(op2);
                    }
                    else if (op == '*')
                    {
                        int p = stack.Pop();
                        stack.Push(p * op2);
                    }
                    else

                    {
                        int p = stack.Pop();
                        stack.Push(p /op2);
                    }

                    op = s[current];

                    start = 1 + current;
                }


                current++;
            }

            return stack.Sum();
        }


        public void Execute()
        {
            Console.WriteLine(Calculate("3-5+2*3/2+2"));
            Console.WriteLine(Calculate("3/2"));
            ;
        }
    }
}