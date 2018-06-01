﻿using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace LeetCode.LeetAgain
{
    class ReverseIntSln : ISolution
    {
        public int ReverseInternal(int x)
        {
            if (x == 0) return 0;
            Queue<int> rev = new Queue<int>();

            int t = x;
            while (t != 0)
            {
                rev.Enqueue(t % 10);
                t = t / 10;
            }

            int result = 0;

            while (rev.Count > 1)
            {
                result += rev.Dequeue();
                result = result * 10;
            }

            result += rev.Dequeue();

            return result;
        }

        public int Reverse(int x)
        {
            if (x == 0) return 0;
            Queue<int> rev = new Queue<int>();

            int t = x;
            while (t != 0)
            {
                rev.Enqueue(t % 10);
                t = t / 10;
            }

            int result = 0;
            try
            {
                while (rev.Count > 1)
                {
                    result = checked(result + rev.Dequeue());
                    result = checked(result * 10);
                }

                result = checked(result + rev.Dequeue());
            }
            catch (OverflowException)
            {
                return 0;
            }

            return result;
        }

        public void Execute()
        {
            Console.WriteLine(Reverse(int.MaxValue));
            Console.WriteLine(Reverse(int.MinValue));
            Console.WriteLine(Reverse(123));
            Console.WriteLine(Reverse(-2321));
            Console.WriteLine(Reverse(101));
            Console.WriteLine(Reverse(120));
            Console.WriteLine(Reverse(1534236469));
            Console.WriteLine(Reverse(0));
        }
    }
}