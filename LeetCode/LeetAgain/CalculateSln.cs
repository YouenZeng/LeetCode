using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode.LeetAgain
{
    class CalculateSln : ISolution
    {
        public int Calculate(string s)
        {
            string trimString = s.Replace(" ", "");

            Stack<string> cStack = new Stack<string>();

            //1. unify data
            //2. add to stack
            //2.1 while met ), find corresponding (, and calculate value

            //3. calculate result of stack(no parentheses)

            throw new NotImplementedException();
        }

        public void Execute()
        {
            string input = @"2-4-(8+2-6+(8+4-(1)+8-10))";
            Calculate(input);
        }
    }
}