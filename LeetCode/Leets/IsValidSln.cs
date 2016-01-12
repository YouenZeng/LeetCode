using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Leets
{
    class IsValidSln : ISolution
    {
        public bool IsValid(string s)
        {
            List<char> lefts = new List<char>() { '(', '[', '{' };
            List<char> rights = new List<char>() { ')', ']', '}' };

            Stack<char> charStack = new Stack<char>();
            foreach (char c in s)
            {

                if (lefts.IndexOf(c) > -1)
                {
                    charStack.Push(c);
                }
                else
                {
                    if (charStack.Count == 0)
                    {
                        return false;
                    }
                    char pop = charStack.Pop();
                    if (lefts.IndexOf(pop) == rights.IndexOf(c))
                    {
                        continue;
                    }
                    return false;
                }
            }
            if (charStack.Count != 0) return false;

            return true;
        }
        public void Execute()
        {
            Console.WriteLine(IsValid("[)"));
        }
    }
}
