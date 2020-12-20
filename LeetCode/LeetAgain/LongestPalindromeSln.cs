using System;
using System.Collections.Generic;

namespace LeetCode.LeetAgain
{
    public class LongestPalindromeSln : ISolution
    {
        public string LongestPalindrome(string s)
        {
            bool[,] checkDp = new bool[s.Length + 1, s.Length + 1];
            int start = 0;
            int max = 0;
            for (int i = 0; i < s.Length; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    if (s[j] == s[i] && (j + 1 > i - 1 || checkDp[j + 1, i - 1]))
                    {
                        checkDp[j, i] = true;
                        int l = i - j;
                        if (l > max)
                        {
                            max = l;
                            start = j;
                        }
                    }
                }
            }

            return s.Substring(start, max + 1);
        }


        public int LongestPalindrome2(string s)
        {
            int[] stat = new int[128];
            for (int i = 0; i < s.Length; i++)
            {
                stat[s[i] - 'A']++;
            }

            bool hasOdd = false;
            int result = 0;
            for (int i = 0; i < stat.Length; i++)
            {
                if (stat[i] % 2 == 0)
                {
                    result += stat[i];
                }
                else
                {
                    result += stat[i];
                    result -= 1;
                    hasOdd = true;
                }
            }
            return hasOdd ? result + 1 : result;
        }

        //private int start, maxLength;
        //public string LongestPalindrome(string s)
        //{
        //    if (s.Length < 2) return s;

        //    for (int i = 0; i < s.Length; i++)
        //    {
        //        DpPalindromic(s, i, i);
        //        DpPalindromic(s, i, i + 1);
        //    }
        //    return s.Substring(start, maxLength);
        //}

        //void DpPalindromic(string s, int begin, int end)
        //{
        //    while (begin >= 0 && end < s.Length && s[begin] == s[end])
        //    {
        //        begin--;
        //        end++;
        //    }

        //    if (maxLength < end - begin - 1)
        //    {
        //        start = begin + 1;
        //        maxLength = end - begin - 1;
        //    }
        //}

        public static String findLongestPalindrome(String s)
        {
            if (string.IsNullOrEmpty(s))
                return "";

            char[] s2 = addBoundaries(s.ToCharArray());
            int[] p = new int[s2.Length];
            int c = 0, r = 0; // Here the first element in s2 has been processed.
            int m = 0, n = 0; // The walking indices to compare if two elements are the same.
            for (int i = 1; i < s2.Length; i++)
            {
                if (i > r)
                {
                    p[i] = 0;
                    m = i - 1;
                    n = i + 1;
                }
                else
                {
                    int i2 = c * 2 - i;
                    if (p[i2] < (r - i - 1))
                    {
                        p[i] = p[i2];
                        m = -1; // This signals bypassing the while loop below. 
                    }
                    else
                    {
                        p[i] = r - i;
                        n = r + 1;
                        m = i * 2 - n;
                    }
                }

                while (m >= 0 && n < s2.Length && s2[m] == s2[n])
                {
                    p[i]++;
                    m--;
                    n++;
                }

                if ((i + p[i]) > r)
                {
                    c = i;
                    r = i + p[i];
                }
            }

            int len = 0;
            c = 0;
            for (int i = 1; i < s2.Length; i++)
            {
                if (len < p[i])
                {
                    len = p[i];
                    c = i;
                }
            }
            char[] dest = new char[len * 2 + 1];
            //char[] ss = copyOfRange(s2, c - len, c + len + 1);
            Array.Copy(s2, c - len, dest, 0, len * 2 + 1);
            return new string(removeBoundaries(dest));
        }

        static char[] copyOfRange(char[] src, int start, int end)
        {
            int len = end - start;
            char[] dest = new char[len];
            Array.Copy(src, start, dest, 0, len);
            return dest;
        }

        private static char[] addBoundaries(char[] cs)
        {
            if (cs == null || cs.Length == 0)
                return "||".ToCharArray();

            char[] cs2 = new char[cs.Length * 2 + 1];
            for (int i = 0; i < (cs2.Length - 1); i = i + 2)
            {
                cs2[i] = '|';
                cs2[i + 1] = cs[i / 2];
            }

            cs2[cs2.Length - 1] = '|';
            return cs2;
        }

        private static char[] removeBoundaries(char[] cs)
        {
            if (cs == null || cs.Length < 3)
                return "".ToCharArray();

            char[] cs2 = new char[(cs.Length - 1) / 2];
            for (int i = 0; i < cs2.Length; i++)
            {
                cs2[i] = cs[i * 2 + 1];
            }

            return cs2;
        }

        void ISolution.Execute()
        {
            Console.WriteLine(findLongestPalindrome("a"));
            Console.WriteLine(findLongestPalindrome("aa"));
            Console.WriteLine(findLongestPalindrome("feaaa"));
            Console.WriteLine(findLongestPalindrome("abccba"));
            Console.WriteLine(findLongestPalindrome("abcba"));
        }
    }
}