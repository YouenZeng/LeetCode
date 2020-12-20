using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode.Challenge
{
    class DecodeStringSln2 : ISolution
    {
        public string DecodeString(string s)
        {
            Stack<char> stack = new Stack<char>();
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] != ']')
                {
                    stack.Push(s[i]);
                }
                else
                {
                    Stack<char> repeatStack = new Stack<char>();
                    while (stack.Count > 0)
                    {
                        char p = stack.Pop();
                        if (p == '[')
                        {
                            break;
                        }

                        repeatStack.Push(p);
                    }

                    Stack<char> countStack = new Stack<char>();
                    while (stack.Count > 0)
                    {
                        char p = stack.Peek();

                        if (p >= '0' && p <= '9')
                        {
                            stack.Pop();
                            countStack.Push(p);
                        }
                        else
                        {
                            break;
                        }
                    }

                    string countString = new string(countStack.ToArray());
                    string repeatString = new string(repeatStack.ToArray());
                    for (int j = 0; j < Convert.ToInt32(countString); j++)
                    {
                        foreach (char c in repeatString)
                        {
                            stack.Push(c);
                        }
                    }
                }
            }


            return string.Join("", stack.Reverse());
        }


        public void Execute()
        {
            string input = "100[leetcode]";
            Console.WriteLine(DecodeString(input));
        }
    }
}