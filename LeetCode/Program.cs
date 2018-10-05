using LeetCode.LeetAgain;
using System;


namespace LeetCode
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ISolution sln = new FindWordsSln();
            sln.Execute();

            int[,] arr = new int[3, 2] { { 1, 2 }, { 1, 2 }, { 1, 2 } };

            Console.ReadLine();
        }
    }
}