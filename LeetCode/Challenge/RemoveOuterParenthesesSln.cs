using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Challenge
{
    class RemoveOuterParenthesesSln : ISolution
    {
        public string RemoveOuterParentheses(string S)
        {
            Stack<char> stack = new Stack<char>();
            stack.Push(S[0]);
            List<string> parts = new List<string>();
            int prev = 0;
            for (int i = 1; i < S.Length; i++)
            {
                if (S[i] == ')')
                {
                    stack.Pop();
                }
                else
                {
                    stack.Push(S[i]);
                }

                if (stack.Count == 0)
                {
                    parts.Add(S.Substring(prev+1, i - prev-1));
                    prev = i+1;
                }
            }

            return string.Join("", parts);
        }

        public void Execute()
        {
            RemoveOuterParentheses("(())");
        }
    }
}