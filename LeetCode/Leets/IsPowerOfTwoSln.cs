using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Leets
{
    class IsPowerOfTwoSln:ISolution
    {
        public bool IsPowerOfTwo(int n)
        {
//            for (int i = 0; i < 31; i++)
//            {
//                if (n == 1 << i)
//                {
//                    Console.WriteLine(i);
//                    return true;
//                }
//            }
//            return false;
            if (n <= 0) return false;
            Console.WriteLine((n & (n - 1)) ==0);
            Console.WriteLine((n & (n - 1)) );
            return false;

           
        }
        public void Execute()
        {
            Console.WriteLine(IsPowerOfTwo(0));
        }
    }
}
