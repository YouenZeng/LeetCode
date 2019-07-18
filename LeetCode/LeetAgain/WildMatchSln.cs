using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.LeetAgain
{
    class WildMatchSln : ISolution
    {
        /*

procedure bt(c)
    if reject(P, c) then return
    if accept(P, c) then output(P, c)
    s ← first(P, c)
    while s ≠ NULL do
       bt(s)
       s ← next(P, s)

             */
        public bool IsMatch(string s, string p)
        {
            if (string.IsNullOrEmpty(p))
                return string.IsNullOrEmpty(s);

            var r = Bt(s, 0, p, 0, -1, 0);

            return r;
        }


        private bool Bt(string s, int sIndex, string p, int pIndex, int lastStar, int lastMatch)
        {
            if (sIndex == s.Length)
            {
                for (int i = pIndex; i < p.Length; i++)
                {
                    if (p[i] != '*')
                        return false;
                }
                return true;
            }

            if (pIndex < p.Length && (s[sIndex] == p[pIndex] || p[pIndex] == '?'))
            {
                return Bt(s, sIndex + 1, p, pIndex + 1, lastStar, lastMatch);
            }

            //记录最新的star pattern 位置,以及最新的匹配字符位置
            //并尝试去匹配下个  pattern, 因为*可以匹配空字符串,所以使用当前字符位置
            if (pIndex < p.Length && p[pIndex] == '*')
            {
                lastStar = pIndex;
                lastMatch = sIndex;
                return Bt(s, sIndex, p, pIndex + 1, lastStar, lastMatch);
            }
            //不满足上面的匹配, 则尝试把上次匹配的字符串匹配到上次的star
            //即       lastMatch+1
            //继续尝试匹配下个pattern
            if (lastStar != -1)
            {
                lastMatch += 1;
                return Bt(s, lastMatch, p, lastStar + 1, lastStar, lastMatch);
            }

            return false;
        }

        public void Execute()
        {

            Console.WriteLine(IsMatch("acdcb", "a*c?b"));
            Console.WriteLine(IsMatch("aa", "a"));
            Console.WriteLine(IsMatch("abbabbbaabaaabbbbbabbabbabbbabbaaabbbababbabaaabbab", "*aabb***aa**a******aa*"));

            Console.WriteLine(IsMatch(string.Empty, "***"));
            //Console.WriteLine(IsMatch("a","a"));
            Console.WriteLine(IsMatch("aa", "a*"));
            Console.WriteLine(IsMatch("a", "a?"));
            Console.WriteLine(IsMatch("aa", "a?"));

            Console.WriteLine(IsMatch("aa", "aa"));
            Console.WriteLine(IsMatch("add", "a?d"));
        }
    }
}