using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LeetCode.Algorithm;
using LeetCode.Dp;
using LeetCode.Infra;
using LeetCode.Leets;

namespace LeetCode
{
    class Program
    {
        static void Main(string[] args)
        {
            ISolution solution = new PackProblem();

            solution.Execute();

            Console.ReadKey();
        }


    }
}
