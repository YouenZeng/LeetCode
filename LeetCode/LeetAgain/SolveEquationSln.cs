using System;
using System.Collections.Generic;

namespace LeetCode.LeetAgain
{
    internal class SolveEquationSln : ISolution
    {
        public string SolveEquation(string equation)
        {
            string noSolution = "No solution";
            string infiniteSolution = "Infinite solutions";
            string[] split = equation.Split(new[] { "=" }, StringSplitOptions.None);

            string left = split[0];
            string right = split[1];

            Tuple<int, int> leftTuple = GetValue(SplitToStack(left));
            Tuple<int, int> rightTuple = GetValue(SplitToStack(right));


            if (leftTuple.Item1 ==  rightTuple.Item1 && leftTuple.Item2 == rightTuple.Item2) return infiniteSolution;
            if (leftTuple.Item2 == rightTuple.Item2) return noSolution;

            return "x="+((leftTuple.Item1 + -1 * rightTuple.Item1) 
                /
                (-1 * leftTuple.Item2 + rightTuple.Item2)
                ).ToString();
        }

        private Queue<string> SplitToStack(string left)
        {
            Queue<string> leftStack = new Queue<string>();
            int leftIndex = 0;
            string temp = string.Empty;
            while (leftIndex < left.Length)
            {
                if (left[leftIndex] == '-' || left[leftIndex] == '+')
                {
                    if (temp != string.Empty)
                    {
                        leftStack.Enqueue(temp);
                    }

                    temp = string.Empty;
                    leftStack.Enqueue(left[leftIndex].ToString());
                }
                else
                {
                    temp += left[leftIndex];
                }
                leftIndex++;
            }
            if (temp != string.Empty)
            {
                leftStack.Enqueue(temp);
            }
            return leftStack;
        }

        private Tuple<int, int> GetValue(Queue<string> stack)
        {
            int result = 0;
            int sign = 1;
            int xResult = 0;
            while (stack.Count > 0)
            {
                string t = stack.Dequeue();
                if (t == "-")
                {
                    sign = -1;
                    continue;
                }
                if (t == "+")
                {
                    sign = 1;
                    continue;
                }
                if (t.IndexOf('x') != -1)
                {
                    if(t.Length == 1)
                    {
                        xResult += 1* sign;
                    }
                    else
                    {
                        xResult += sign*Convert.ToInt32(t.Replace("x", ""));
                    }
                    
                    
                    continue;
                }
                int v = Convert.ToInt32(t);
                result += v * sign;
            }
            Tuple<int, int> tt = new Tuple<int, int>(result, xResult);

            return tt;
        }

        public void Execute()
        {
            Console.WriteLine(SolveEquation("2+2-x+x+3x=x+2x-x+x+4"));

        }
    }
}
