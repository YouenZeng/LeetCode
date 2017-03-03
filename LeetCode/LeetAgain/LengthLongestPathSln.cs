using System;
using System.Collections.Generic;
using LeetCode;

namespace Leetcode.LeetAgain
{
    public class LengthLongestPathSln : ISolution
    {
        public int LengthLongestPath(string input)
        {
            Stack<int> depthStack = new Stack<int>();
            depthStack.Push(0);
            string[] arr = input.Split(new[] { "\\n" }, StringSplitOptions.None);

            int maxDepth = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                int charIndex = arr[i].LastIndexOf("\\t");

                if (charIndex == -1)
                {
                    charIndex = 0;
                }
                else
                {
                    charIndex += 2;
                }

                int depth = charIndex / 2;

                while (depthStack.Count > depth + 1)
                    depthStack.Pop();

                int length = depthStack.Peek() + arr[i].Length - charIndex + 1;
                depthStack.Push(length);

                if (arr[i].Contains("."))
                {
                    maxDepth = Math.Max(maxDepth, length - 1);
                }
            }

            return maxDepth;
        }

        void ISolution.Execute()
        {
            System.Console.WriteLine(LengthLongestPath(@"dir\n\tsubdir1\n\t\tfile1.ext\n\t\tsubsubdir1\n\tsubdir2\n\t\tsubsubdir2\n\t\t\tfile2.ext"));
            System.Console.WriteLine(LengthLongestPath(@"dir\n\tsubdir1\n\tsubdir2\n\t\tfile.ext"));
        }
    }
}