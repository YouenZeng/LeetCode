using System;
using System.Diagnostics;
using System.IO;
using LeetCode.Leets;

namespace LeetCode
{
    internal class Program
    {
        public static void Main()
        {
            ISolution sln = new SubsetsSln();
            sln.Execute();
            
            Console.ReadLine();
        }

    }
}

