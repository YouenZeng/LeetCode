using LeetCode.Infra;
using LeetCode.LeetAgain;
using System;
using System.Diagnostics;

namespace LeetCode
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ISolution sln = new FindBottomLeftValueSln();
            sln.Execute();

            Console.ReadLine();
        }
    }
}

