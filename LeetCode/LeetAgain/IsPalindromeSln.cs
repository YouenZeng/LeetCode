using System;
using System.Collections.Generic;
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

    /// <summary>
    /// 125
    /// </summary>
    /// <param name="s"></param>
    /// <returns></returns>
    public bool IsPalindrome(string s)
    {
        char[] c = s.ToCharArray();
        for (int i = 0, j = c.Length - 1; i < j;)
        {
            if (!char.IsLetterOrDigit(c[i])) i++;
            else if (!char.IsLetterOrDigit(c[j])) j--;
            else if (char.ToLower(c[i++]) != char.ToLower(c[j--]))
                return false;
        }

        return true;
    }

    public bool IsPalindrome(ListNode head)
    {
        throw new NotImplementedException();
    }

    void ISolution.Execute()
    {
        System.Console.WriteLine(IsPalindrome("A man, a plan, a canal: Panama"));
        System.Console.WriteLine(IsPalindrome(1));
        System.Console.WriteLine(IsPalindrome(1001));
        System.Console.WriteLine(IsPalindrome(100001));
    }
}