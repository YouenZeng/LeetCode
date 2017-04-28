using System;
using LeetCode;
using LeetCode.Leets;
public class IsPalindromeSln : ISolution
{

    public bool IsPalindrome(int x)
    {
        int result = 0;
        if (x < 0) return false;
        if (x != 0 && x % 10 == 0) return false;
        while (result < x)
        {
            result = result * 10 + x % 10;
            x = x / 10;
        }

        return (x == result) || (x == result / 10);
        //throw new NotImplementedException();
    }

    public bool IsPalindrome(ListNode head)
    {
        

        throw new NotImplementedException();
    }

    void ISolution.Execute()
    {
        System.Console.WriteLine(IsPalindrome(12321));
        System.Console.WriteLine(IsPalindrome(1));
        System.Console.WriteLine(IsPalindrome(1001));
        System.Console.WriteLine(IsPalindrome(100001));
    }
}