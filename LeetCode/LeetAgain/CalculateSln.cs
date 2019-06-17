using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode.LeetAgain
{
    class CalculateSln : ISolution
    {

        HashSet<char> hs = new HashSet<char>(

            new List<char>()
            {
                ' ','(',')','+','-'
            }
        );
        public int Calculate(string s)
        {
            Stack<string> cStack = new Stack<string>();

            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == ' ')
                    continue;
                if (s[i] == '+' || s[i] == '-'|| s[i] == '(')
                {
                    cStack.Push(s[i].ToString());
                    continue;
                }

                if (s[i] == ')')
                {
                    int r = HandleP(cStack);
                    cStack.Push(r.ToString());
                    continue;
                }

                string s1 = string.Empty;

                while (i < s.Length && !hs.Contains(s[i]))
                {
                    s1 += s[i];
                    i++;
                }

                i--;
                cStack.Push(s1);
            }

            return HandleP(cStack);
        }

        private int HandleP(Stack<string> cStack)
        {
            Stack<string> op = new Stack<string>();
            while (cStack.Count > 0)
            {
                var c = cStack.Pop();
                if (c == "(")
                {
                    break;
                }

                op.Push(c);
            }

            int r = 0;
            string addOrMinus = "+";
            while (op.Count > 0)
            {
                var c = op.Pop();

                if (c == "+" || c == "-")
                {
                    addOrMinus = c;
                    continue;
                }

                int num = Convert.ToInt32(c);

                if (addOrMinus == "+")
                    r += num;
                else
                {
                    r -= num;
                }
            }

            return r;
        }


        public void Execute()
        {
            string input = @"2+5+8+4";
            Calculate(input);
        }
    }
}