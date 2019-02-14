using LeetCode.Algorithm;
using LeetCode.LeetAgain;
using System;


namespace LeetCode
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ISolution sln = new LongestIncreasingPathSln();
            sln.Execute();

            Console.ReadLine();
        }
    }
}