using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Leets
{
    class CountAndSaySln : ISolution
    {
        public string CountAndSay(int n)
        {
            StringBuilder output = new StringBuilder();
            output.Append("1");
            for (int i = 1; i < n; i++)
            {
                
                string input = output.ToString();
                output.Clear();
                char prev = input[0];
                int currentCount = 0;
                foreach (char c in input)
                {
                    if (c == prev)
                    {
                        currentCount++;
                    }
                    else
                    {
                        output.Append(currentCount + prev.ToString());
                        prev = c;
                        currentCount = 1;
                    }
                }
                output. Append(currentCount + prev.ToString());
                
            }

            return output.ToString();
        }
        public void Execute()
        {
            Console.Write(CountAndSay(9));
        }
    }
}
