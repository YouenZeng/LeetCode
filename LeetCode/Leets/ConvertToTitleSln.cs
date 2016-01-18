using System;

namespace LeetCode.Leets
{
    class ConvertToTitleSln : ISolution
    {
        public string ConvertToTitle(int n)
        {
            string result = string.Empty;
            // A: 65
            while (n > 0)
            {
                if (n % 26 == 0)
                {
                    result = 'Z' + result;
                    n = n / 26 - 1;
                }
                else
                {
                    result = Convert.ToChar(n % 26 + 64) + result;
                    n = n/26;
                }
            }
            return result;
        }
        public void Execute()
        {
            Console.WriteLine(ConvertToTitle(1));
            Console.WriteLine(ConvertToTitle(12));
            Console.WriteLine(ConvertToTitle(52));
            Console.WriteLine(ConvertToTitle(26));
            Console.WriteLine(ConvertToTitle(27));
            Console.WriteLine(ConvertToTitle(28));
        }
    }
}
