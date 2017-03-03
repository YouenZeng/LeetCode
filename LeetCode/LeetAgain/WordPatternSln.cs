using System;
using System.Collections.Generic;

namespace LeetCode.LeetAgain
{
    public class WordPatternSln : ISolution
    {
        public bool WordPattern(string pattern, string str)
        {
            string[] arr = str.Split(' ');
            if (pattern.Length != arr.Length)
                return false;

            int length = arr.Length;
            Dictionary<char, string> dict = new Dictionary<char, string>();
            for (int i = 0; i < length; i++)
            {
                if (dict.ContainsKey(pattern[i]) == false)
                {
                    if (dict.ContainsValue(arr[i]))
                    {
                        return false;
                    }
                    dict.Add(pattern[i], arr[i]);
                }
                else
                {
                    if ((dict[pattern[i]]) != arr[i])
                    {
                        return false;
                    }
                }
            }

            return true;
        }
        void ISolution.Execute()
        {
            System.Console.WriteLine(WordPattern("abba", "dog cat cat dog"));
            System.Console.WriteLine(WordPattern("abba", "dog cat cat fish"));
        }
    }
}