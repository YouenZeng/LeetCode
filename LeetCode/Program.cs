using LeetCode.Infra;
using LeetCode.LeetAgain;
using LeetCode.Leets;
using System;
using System.Diagnostics;

namespace LeetCode
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ISolution sln = new InorderTraversalSln();
            sln.Execute();

            Console.ReadLine();
        }
    }
}