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

            var r = Bt(s, 0, p, 0, 0);

            return r;
        }


        private bool Bt(string s, int sIndex, string p, int pIndex, int lastStar)
        {
            Console.WriteLine($"{sIndex}-{pIndex}");

            if (sIndex >= s.Length)
            {
                if (pIndex >= p.Length)
                {
                    return true;
                }

                for (int i = pIndex; i < p.Length; i++)
                {
                    if (p[i] != '*')
                        return false;
                }

                return true;
            }

            if (pIndex >= p.Length)
                return false;


            if (p[pIndex] == '?' || p[pIndex] == s[sIndex])
            {
                return Bt(s, sIndex + 1, p, pIndex + 1, lastStar);
            }

            if (p[pIndex] == '*')
            {
                lastStar = pIndex;
                return Bt(s, sIndex + 1, p, pIndex + 1, lastStar);
            }

            return Bt(s, sIndex, p, lastStar, lastStar);
        }

        public void Execute()
        {
            Console.WriteLine(IsMatch("abbabbbaabaaabbbbbabbabbabbbabbaaabbbababbabaaabbab", "*aabb***aa**a******aa*"));
            Console.WriteLine(IsMatch("adceb", "*a*b"));
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