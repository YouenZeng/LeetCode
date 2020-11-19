using System;
using System.Collections.Generic;

namespace LeetCode.Challenge
{
    class DecodeStringSln : ISolution
    {
        public string DecodeString(string s)
        {
            List<string> temp = new List<string>();

            int start = 0;
            int end = s.Length;

            Stack<char> stack = new Stack<char>(s.ToCharArray());
            while (stack.Count > 0)
            {
                var p = stack.Pop();
                if (p >= '0' && p <= '9')
                {
                }
            }


            return string.Join("", temp);
        }


        public void Execute()
        {
            string input = "9[9[9[a]b9[a]]]";
            Console.WriteLine(DecodeString(input));
        }
    }
}