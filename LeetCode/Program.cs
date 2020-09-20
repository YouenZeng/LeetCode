using LeetCode.Infra;
using LeetCode.LeetAgain;
using System;
using LeetCode.Algorithm;


namespace LeetCode
{
    internal class Program
    {
        static void Main(string[] args)
        {

            ISolution sln = new LongestConsecutiveSln();
            sln.Execute();

            Console.ReadLine();
        }
    }


}