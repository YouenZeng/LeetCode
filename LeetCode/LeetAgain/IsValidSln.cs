using System;
using System.Collections.Generic;

namespace LeetCode.LeetAgain
{
    class IsValidSln : ISolution
    {
        public bool IsValid(string s)
        {
            int start = 0;
            int end = s.Length - 1;
            if (string.IsNullOrEmpty(s))
                return true;
            Stack<char> stack = new Stack<char>();
            stack.Push(s[start]);
            while (start++ < end)
            {
                //start++;
                if (s[start] == '(' || s[start] == '[' || s[start] == '{')
                {
                    stack.Push(s[start]);
                    continue;
                }

                if (stack.Count == 0)
                    return false;

                if (s[start] == ')' && stack.Pop() != '(')
                {
                    return false;
                }

                if (s[start] == ']' && stack.Pop() != '[')
                {
                    return false;
                }

                if (s[start] == '}' && stack.Pop() != '{')
                {
                    return false;
                }
            }

            return stack.Count == 0;
        }

        public void Execute()
        {
            Console.WriteLine(IsValid("()()()"));
            ;
        }
    }
}