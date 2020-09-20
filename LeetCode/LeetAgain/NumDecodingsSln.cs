using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.LeetAgain
{
    class NumDecodingsSln : ISolution
    {
        public int NumDecodings(string s)
        {
            if (s.Length == 0) return 0;
            if (s[0] == '0') return 0;

            int prev = 1;
            int current = 1;
            for (int i = 1; i < s.Length; i++)
            {
                if (s[i] == '0')
                {
                    current = 0;
                }

                if (s[i - 1] == '1' || (s[i - 1] == '2' && s[i] <= '6'))
                {
                    current = current + prev;
                    prev = current - prev;
                }
                else
                {
                    prev = current;
                }
            }

            return current;
        }

        public void Execute()
        {
            Console.WriteLine(NumDecodings("111626"));
            Console.WriteLine(NumDecodings("301"));
            Console.WriteLine(NumDecodings("122821"));
            Console.WriteLine(NumDecodings("101"));
            Console.WriteLine(NumDecodings("100"));
        }
    }
}