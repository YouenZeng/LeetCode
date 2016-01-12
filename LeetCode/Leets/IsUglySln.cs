using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Leets
{
    class IsUglySln : ISolution
    {
        public bool IsUgly(int num)
        {
            for (int i = 2; i < 6; i++)
            {
                while (num % i == 0)
                {
                    num = num / i;
                }
            }
            return num == 1;
        }
        public void Execute()
        {
            Console.WriteLine(IsUgly(9));
        }
    }
}
