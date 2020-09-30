using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetCode.LeetAgain
{
    public class MinCutSln:ISolution
    {

        readonly IList<IList<string>> result = new List<IList<string>>();

        public IList<IList<string>> Partition(string s)
        {
            if (string.IsNullOrEmpty(s))
                return result;
            Dfs(s, 0, new Stack<string>());

            return result;
        }

        private void Dfs(string s, int startIndex, Stack<string> stack)
        {
            for (int i = startIndex; i < s.Length; i++)
            {
                if (IsPalindrome(s, startIndex, i))
                {
                    stack.Push(s.Substring(startIndex, i - startIndex + 1));
                    Dfs(s, i + 1, stack);
                    stack.Pop();
                }
            }

            if (startIndex == s.Length)
            {
                result.Add(new List<string>(stack.Reverse()));
            }
        }

        private bool IsPalindrome(string s, int start, int end)
        {
            while (start < end)
            {
                if (s[start++] != s[end--])
                {
                    return false;
                }
            }

            return true;
        }


        public int MinCut(string s)
        {
            throw new NotImplementedException();
        }
        public void Execute()
        {
            throw new System.NotImplementedException();
        }
    }
}