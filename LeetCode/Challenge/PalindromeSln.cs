using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Challenge
{
    class PalindromeSln : ISolution
    {
        private List<IList<string>> result;

        public IList<IList<string>> Partition(string s)
        {
            result = new List<IList<string>>();
            List<string> list = new List<string>();
            Dfs(list, s, 0);
            return result;
        }

        private void Dfs(List<string> current, string s, int start)
        {
            if (start == s.Length)
            {
                result.Add(new List<string>(current));
            }

            for (int i = start; i < s.Length; i++)
            {
                if (IsPalindrome(s, start, i))
                {
                    current.Add(s.Substring(start, i - start + 1));
                    Dfs(current, s, i + 1);
                    current.RemoveAt(current.Count - 1);
                }
            }
        }

        private bool IsPalindrome(string s, int from, int to)
        {
            if (from == to)
            {
                return true;
            }

            while (from < to)
            {
                if (s[from] != s[to])
                {
                    return false;
                }

                from++;
                to--;
            }

            return true;
        }

        public void Execute()
        {
            Partition("aab");
        }
    }
}