using System;

namespace LeetCode.LeetAgain
{
    public class TitleToNumberSln : ISolution
    {
        public int TitleToNumber(string s)
        {
            int result = 0;
            foreach (var t in s)
            {
                result = result * 26 + t - 'A' + 1;
            }
            return result;
        }

        public void Execute()
        {
            Console.WriteLine(TitleToNumber("A"));
            Console.WriteLine(TitleToNumber("AB"));
            Console.WriteLine(TitleToNumber("ZY"));
        }
    }
}