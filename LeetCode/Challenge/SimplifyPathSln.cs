using System.Collections.Generic;
using System.Linq;

namespace LeetCode.Challenge
{
    class SimplifyPathSln : ISolution
    {
        public string SimplifyPath(string path)
        {
            Stack<string> stack = new Stack<string>();

            string[] arr = path.Split('/');
            foreach (string s in arr)
            {
                if (stack.Count > 0 && s == "..")
                {
                    stack.Pop();
                    continue;
                }

                if (s != string.Empty && s != "." && s != "..")
                {
                    stack.Push(s);
                }
            }

            return "/" + string.Join("/", stack.ToArray().Reverse());
        }

        public void Execute()
        {
            string input = "/a/./b/../../c/";
            string s = SimplifyPath(input);
        }
    }
}