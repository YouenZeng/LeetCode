using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Leets
{
    class AddDigitsSln:ISolution
    {
        public int AddDigits(int num)
        {
            return num%9;
        }

        public void Execute()
        {
            Console.WriteLine(512%9);
        }
    }
}
