using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetCode.LeetAgain
{
    public class EvalRPNSln : ISolution
    {
        public int EvalRPN(string[] tokens)
        {
            HashSet<string> hs = new HashSet<string>() {"+", "-", "*", "/"};
            Stack<int> stack = new Stack<int>();
            for (int i = 0; i < tokens.Length; i++)
            {
                if (hs.Contains(tokens[i]))
                {
                    var op2 = stack.Pop();
                    var op1 = stack.Pop();
                    switch (tokens[i])
                    {
                        case "+":
                        {
                            stack.Push(op1 + op2);
                            break;
                        }
                        case "-":
                        {
                            stack.Push(op1 - op2);
                            break;
                        }
                        case "*":
                        {
                            stack.Push(op1 * op2);
                            break;
                        }
                        case "/":
                        {
                            stack.Push(op1 / op2);
                            break;
                        }
                    }
                }
                else
                {
                    stack.Push(Convert.ToInt32(tokens[i]));
                }
            }

            return stack.Pop();
        }

        public void Execute()
        {
            var t1 = new List<string>()
            {
                "10", "6", "9", "3", "+", "-11", "*", "/", "*", "17", "+", "5", "+"
            };

            var a = EvalRPN(t1.ToArray());
        }
    }
}