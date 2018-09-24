using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Security.Cryptography;
using System.Text;

namespace LeetCode.LeetAgain
{
    class IsInterleaveSln : ISolution
    {
        public bool IsInterleave(string s1, string s2, string s3)
        {
            if (s1.Length + s2.Length != s3.Length) return false;
            bool[,] cache = new bool[s1.Length + 1, s2.Length + 1];

            cache[0, 0] = true;
            for (int i = 1; i <= s1.Length; i++)
            {
                cache[i, 0] = cache[i-1,0] && (s1[i-1] == s3[i-1]);
            }

            for (int i = 1; i <= s2.Length; i++)
            {
                cache[0, i] = cache[0, i - 1] && (s2[i-1] == s3[i-1]);
            }

            for (int i = 1; i <= s1.Length; i++)
            {
                for (int j = 1; j <= s2.Length; j++)
                {
                    cache[i, j] = (s1[i - 1] == s3[i + j - 1] && cache[i - 1, j]) || (s2[j - 1] == s3[i + j - 1] && cache[i, j - 1]);
                }
            }

            return cache[s1.Length, s2.Length];
        }

        public void Execute()
        {
            string s1 = "a";
            string s2 = "";
            string s3 = "a";

            Console.WriteLine(IsInterleave(s1, s2, s3));
        }
    }
}
