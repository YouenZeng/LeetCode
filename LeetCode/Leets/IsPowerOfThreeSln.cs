using System;

namespace LeetCode.Leets
{
    //Given an integer, write a function to determine if it is a power of three.
    class IsPowerOfThreeSln : ISolution
    {
        public bool IsPowerOfThree(int n)
        {
            int val = n;
            if (val == 1) return true;
            if (val % 3 != 0) return false;
            while (val != 0 && val % 3 == 0)
            {
                if (val == 3) return true;
                val = val / 3;
            }

//            Math.Pow(3, Math.Log(0x7fffffff))/Math.Log(3);
            return false;
        }
        public void Execute()
        {
            Console.WriteLine(Math.Log(3));
            Console.WriteLine(Math.Pow(3,4));
            Console.WriteLine(Math.Log(0x7fffffff));
            Console.WriteLine(IsPowerOfThree(0));
            Console.WriteLine(IsPowerOfThree(9));
            Console.WriteLine(IsPowerOfThree(27));
            Console.WriteLine(IsPowerOfThree(30));
        }
    }
}
