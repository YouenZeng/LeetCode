using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.LeetAgain
{
    public class CountNumbersWithUniqueDigitsSln : ISolution
    {
        public int CountNumbersWithUniqueDigits(int n)
        {
            if (n == 0)
                return 1;
            int current = 9;
            int result = 10;
            for (int i = 2; i <= n && i <= 10; i++)
            {
                current *= (9 - i + 2);
                result += current;
            }

            return result;
        }
        public void Execute()
        {
            Console.WriteLine(CountNumbersWithUniqueDigits(2));
            Console.WriteLine(CountNumbersWithUniqueDigits(3));
            Console.WriteLine(CountNumbersWithUniqueDigits(4));
            Console.WriteLine(CountNumbersWithUniqueDigits(5));
        }
    }
}
