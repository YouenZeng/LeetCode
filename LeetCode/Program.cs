using System;
using System.IO;
using LeetCode.Leets;

namespace LeetCode
{
    internal class Program
    {
        public static void Main()
        {
            ISolution soln = new FirstBadVersionSln();
            soln.Execute();

            Console.ReadLine();
        }
    }
}
