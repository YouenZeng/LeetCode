using LeetCode.LeetAgain;
using System;

namespace LeetCode
{
    internal class Program
    {
        static void Main(string[] args)
        {

            try
            {
                ISolution sln = new NumberOfBoomerangsSln();
                sln.Execute();
            }
            catch (System.Exception ex)
            {
                System.Console.WriteLine(ex.Message);
                System.Console.WriteLine(ex.StackTrace);
            }

            Console.ReadLine();
        }
    }
}

