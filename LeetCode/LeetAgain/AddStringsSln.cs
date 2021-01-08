using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode.LeetAgain
{
    class AddStringsSlnL : ISolution
    {
        public string AddStrings(string num1, string num2)
        {
            StringBuilder sb = new StringBuilder();

            int n1 = num1.Length-1;
            int n2 = num2.Length-1;

            bool hasCarry = false;
            while (n1 >= 0 || n2 >= 0)
            {
                char c1 = '0';
                char c2 = '0';
                if (n1 >= 0)
                {
                    c1 = num1[n1];
                    n1--;
                }
                if (n2 >= 0)
                {
                    c2 = num2[n2];
                    n2--;
                }

                int sum = (c1 - '0') + (c2 - '0');
                if (hasCarry)
                {
                    sum += 1;
                }
                if (sum >= 10)
                {
                    sb.Append((char)((sum - 10) + '0'));
                    hasCarry = true;
                }
                else
                {
                    sb.Append((char)((sum + '0')));
                    hasCarry = false;
                }
            }
            if (hasCarry)
            {
                sb.Append("1");
            }

            string r = sb.ToString();
            return string.Join("", r.Reverse());
        }
        public void Execute()
        {
            Console.WriteLine(AddStrings("1", "2"));
            Console.WriteLine(AddStrings("99999", "1"));
            Console.WriteLine(AddStrings("99999", "99999"));
            Console.WriteLine(AddStrings("111111", "2"));

        }
    }
}
