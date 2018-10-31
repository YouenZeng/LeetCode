using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.LeetAgain
{
    class BackspaceCompareSln : ISolution
    {
        public bool BackspaceCompare(string S, string T)
        {
            Stack<char> sStack = new Stack<char>();
            Stack<char> tStack = new Stack<char>();

            foreach (char c in S)
            {
                if (c == '#')
                {
                    if (sStack.Count > 0)
                        sStack.Pop();
                }
                else sStack.Push(c);
            }
            foreach (char c in T)
            {
                if (c == '#')
                {
                    if (tStack.Count > 0)
                        tStack.Pop();
                }
                else tStack.Push(c);
            }

            if (sStack.Count != tStack.Count) return false;

            while (sStack.Count != 0)
            {
                if (sStack.Pop() != tStack.Pop()) return false;
            }
            return true;

        }
        public void Execute()
        {
            throw new NotImplementedException();
        }
    }
}
