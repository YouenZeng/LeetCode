using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.LeetAgain
{
    class IsMatchSln : ISolution
    {
        public bool IsMatch(string s, string p)
        {
            if (string.IsNullOrEmpty(p)) return string.IsNullOrEmpty(s);

            if (p.Length > 1 && p[1] == '*')
                return IsMatch(s, p.Substring(2))
                    || string.IsNullOrEmpty(s) == false
                    && (s[0] == p[0] || '.' == p[0]) && IsMatch(s.Substring(1), p);
            else
                return string.IsNullOrEmpty(s) == false && (s[0] == p[0] || '.' == p[0]) && IsMatch(s.Substring(1), p.Substring(1));
        }
        public void Execute()
        {
            Console.WriteLine(IsMatch("aab", "c*a*b"));
            Console.WriteLine(IsMatch("aacd", "d*"));
            Console.WriteLine(IsMatch("ab", ".*c"));
            Console.WriteLine(IsMatch("aa", "a*"));
            Console.WriteLine(IsMatch("ab", ".*"));
            Console.WriteLine(IsMatch("aab", "c*a*b*"));
            Console.WriteLine(IsMatch("mississippi", "mis*is*ip*."));
            Console.WriteLine(IsMatch("aaa", "a*a"));
        }
    }
}
