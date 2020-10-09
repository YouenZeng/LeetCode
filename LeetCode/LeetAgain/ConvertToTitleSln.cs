using System;
using System.Collections.Generic;

namespace LeetCode.LeetAgain
{
    public class ConvertToTitleSln : ISolution
    {
        public string ConvertToTitle(int n)
        {
            List<char> t = new List<char>();

            while (n != 0)
            {
                int m = (n - 1) % 26;
                t.Add((char) ('A' + m));
                n = (n - 1) / 26;
            }

            t.Reverse();
            var s = new string(t.ToArray());
            return s;
        }

        public void Execute()
        {
            Console.WriteLine(ConvertToTitle(26));
            Console.WriteLine(ConvertToTitle(28));
            Console.WriteLine(ConvertToTitle(701));
        }
    }
}