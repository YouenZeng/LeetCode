using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace LeetCode.LeetAgain
{
    class LongestPrefixSln : ISolution
    {
        public string LongestPrefix(string s)
        {
            int len = s.Length;
            string result = string.Empty;
            int max = 0;
            for (int i = len - 1; i >= 0; i--)
            {
                int left = 0;
                int right = len - 1;

                while (left < len - i)
                {
                    if (s[left] == s[left + i] && s[right] == s[right - i])
                    {
                        left++;
                        right--;
                    }
                    else
                    {
                        break;
                    }
                }

                if (left == len - i)
                {
                    max = i;
                }
              
            }

            return s.Substring(0, max);
        }

        public void Execute()
        {
            Console.WriteLine(LongestPrefix("babaabacb"));
            Console.WriteLine(LongestPrefix("ababab"));
            Console.WriteLine(LongestPrefix("leetcodeleet"));
            Console.WriteLine(LongestPrefix("leeetcodeleet"));
        }
    }
}