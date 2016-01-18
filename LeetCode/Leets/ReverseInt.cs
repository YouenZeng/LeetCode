using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Leets
{
    class ReverseInt : ISolution
    {
        public int Reverse(int x)
        {

            int num = 0;
            try
            {
                while (x != 0)
                {
                    int yu = x % 10;
                    x = x / 10;
                    num = checked(num * 10 + yu);
                }
            }
            catch (OverflowException)
            {
               return 0;
            }

            return num;

        }
        public void Execute()
        {
            //            Console.WriteLine(Reverse(0));
            //            Console.WriteLine(Reverse(1));
            //            Console.WriteLine(Reverse(10));
            //            Console.WriteLine(Reverse(100));
            //            Console.WriteLine(Reverse(-1));
            //            Console.WriteLine(Reverse(-100));
            //            Console.WriteLine(Reverse(-2147483648));
            Console.WriteLine(Reverse(1534236469));
        }
    }
}
