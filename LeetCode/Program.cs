using LeetCode.Infra;
using LeetCode.LeetAgain;
using System;


namespace LeetCode
{
    internal class Program
    {
        static void Main(string[] args)
        {

            ISolution sln = new PathSumSln();
            sln.Execute();

            Console.ReadLine();
        }
    }


}