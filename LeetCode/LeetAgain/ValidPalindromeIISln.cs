using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.LeetAgain
{
    class ValidPalindromeIISln : ISolution
    {
        private bool IsValidPalindrome(string s, int start, int end)
        {
            while (start < end)
            {
                if (s[start] != s[end])
                {
                    return false;
                }
                start++;
                end--;
            }
            return true;
        }
        public bool ValidPalindrome(string s)
        {
            int start = 0;
            int end = s.Length - 1;
            while (start < end)
            {
                if (s[start] != s[end])
                {
                    return IsValidPalindrome(s, 1 + start, end) || IsValidPalindrome(s, start, end - 1);
                }
                start++;
                end--;
            }

            return true;

        }
        public void Execute()
        {
            Console.WriteLine(ValidPalindrome("aguokepatgbnvfqmgmlcupuufxoohdfpgjdmysgvhmvffcnqxjjxqncffvmhvgsymdjgpfdhooxfuupuculmgmqfvnbgtapekouga"));
            Console.WriteLine(ValidPalindrome("ab"));
            Console.WriteLine(ValidPalindrome("aaa"));
            Console.WriteLine(ValidPalindrome("aba"));
            Console.WriteLine(ValidPalindrome("abac"));
            Console.WriteLine(ValidPalindrome("abca"));
            Console.WriteLine(ValidPalindrome("abbfca"));
        }
    }
}
