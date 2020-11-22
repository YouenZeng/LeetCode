using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Challenge
{
    class AtMostNGivenDigitSetSln : ISolution
    {
        public int AtMostNGivenDigitSet(string[] digits, int n)
        {
            char[] N = n.ToString().ToCharArray();
            int len = N.Length;
            int res = 1, pres = 1, smaller = -1;

            for (int i = 1, m = 1; i <= len; i++, m *= digits.Length)
            {
                pres = res;
                res = 0;
                int x = N[len - i] - '0';
                foreach (var d in digits)
                {
                    if (Convert.ToInt32(d) < x) res += m;
                    else if (Convert.ToInt32(d) == x) res += pres;
                }
                smaller += m;
            }

            return res + smaller;
        }

        public void Execute()
        {
            Console.WriteLine(AtMostNGivenDigitSet(new string[] { "1", "7" }, 231));
            Console.WriteLine(AtMostNGivenDigitSet(new string[] { "1", "3", "5", "7" }, 74));
            Console.WriteLine(AtMostNGivenDigitSet(new string[] { "1", "4", "9" }, 900000000));
        }
    }
}
