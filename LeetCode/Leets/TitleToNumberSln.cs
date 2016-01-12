using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Leets
{
    class TitleToNumberSln : ISolution
    {
        public int TitleToNumber(string s)
        {
            int currentResult = 0;
            int currentSeed = 1;
            for (int i = s.Length-1; i >=0; i--)
            {
                currentResult += (char.ToUpper(s[i]) - 64) * currentSeed;
                currentSeed *= 26;
            }
            return currentResult;
        }
        public void Execute()
        {
            Console.WriteLine(TitleToNumber("AB"));
        }
    }
}
