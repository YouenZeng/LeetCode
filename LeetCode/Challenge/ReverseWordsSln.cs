using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Challenge
{
    class ReverseWordsSln : ISolution
    {
        public void ReverseWords(char[] s)
        {
            Reverse(s, 0, s.Length - 1);
            int prev = 0;
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == ' ')
                {
                    Reverse(s, prev, i - 1);
                    prev = 1 + i;
                }
            }

            Reverse(s, prev, s.Length - 1);
        }

        private void Reverse(char[] s, int from, int to)
        {
            while (from <= to)
            {
                char t = s[from];
                s[from] = s[to];
                s[to] = t;
                from++;
                to--;
            }
        }

        public void Execute()
        {
            ReverseWords(new char[] {'t', 'h', 'e', ' ', 's', 'k', 'y', ' ', 'i', 's', ' ', 'b', 'l', 'u', 'e'});
        }
    }
}