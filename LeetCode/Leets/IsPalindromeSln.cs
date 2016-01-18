using System;

namespace LeetCode.Leets
{
    class IsPalindromeSln : ISolution
    {
        public bool IsPalindrome(int x)
        {
            int input = x;
            int newNum = 0;
            while (x > 0)
            {
                int yu = x % 10;
                x = x / 10;
                newNum = newNum * 10 + yu;
            }

            return newNum == input;
        }
        public void Execute()
        {
            Console.WriteLine(IsPalindrome(1233321));
        }
    }
}
