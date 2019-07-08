using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.LeetAgain
{
    class LongestValidParenthesesSln : ISolution
    {
        public int LongestValidParentheses(string s)
        {
            //use a stack
            //if current char is (, push it to stack
            //if current char is )
            // 1. if stack.peek() is (, continue
            // 2. if stack.Peek() is ), push the index of ) to stack

            // after the loop is done
            // check adjacent index


            Stack<int> stack = new Stack<int>();
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == '(')
                {
                    stack.Push(i);
                }

                if (s[i] == ')')
                {
                    if (stack.Count > 0 && s[stack.Peek()] == '(')
                    {
                        stack.Pop();
                        continue;
                    }

                    stack.Push(i);
                }
            }

            int result = 0;
            if (stack.Count == 0)
                result = s.Length;

            int seed = s.Length;
            while (stack.Count > 0)
            {
                int p = stack.Pop();
                result = Math.Max(result, seed - p - 1);
                seed = p;
            }

            result = Math.Max(result, seed);

            return result;
        }

        public void Execute()
        {
            LongestValidParentheses("(()");
            LongestValidParentheses(")()())");
        }
    }
}