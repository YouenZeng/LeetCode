using System;
using LeetCode.Challenge;

namespace LeetCode
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ISolution sln = new Challenge.CheckArithmeticSubarraysSln();
            sln.Execute();

            Console.ReadLine();
        }
    }




}