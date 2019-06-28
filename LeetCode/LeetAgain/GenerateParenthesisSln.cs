using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;

namespace LeetCode.LeetAgain
{
    class GenerateParenthesisSln : ISolution
    {
        public IList<string> GenerateParenthesis(int n)
        {
            //a tree height 6 (n*2)
            //traverse to see if path meet requirements
            //purge if not meet

            IList<string> result = new List<string>();
            Dfs("(", n * 2 - 1, n * 2, result);
            return result;
        }

        private void Dfs(string s, int n, int maxCount, IList<string> result)
        {
            if (!IsBadFormat(s, maxCount))
                return;

            if (n == 0)
            {
                result.Add(s);
                return;
            }

            Dfs(s + "(", n - 1, maxCount, result);
            Dfs(s + ")", n - 1, maxCount, result);
        }

        private bool IsBadFormat(string s, int maxCount)
        {
            if (s.Length == 0)
                return true;
            Stack<char> stack = new Stack<char>();
            stack.Push(s[0]);
            for (int i = 1; i <= s.Length - 1; i++)
            {
                if (s[i] == '(')
                {
                    stack.Push(s[i]);
                    continue;
                }

                if (stack.Count == 0 || stack.Pop() != '(')
                {
                    return false;
                }
            }

            if ((maxCount - s.Length) < stack.Count)
                return false;

            return true;
        }

        public void Execute()
        {
            GenerateParenthesis(1);
            GenerateParenthesis(3);
            Console.WriteLine(IsBadFormat("(()(", 6));
            Console.WriteLine(IsBadFormat("())((", 6));
            Console.WriteLine(IsBadFormat("(()))", 6));
        }
    }
}