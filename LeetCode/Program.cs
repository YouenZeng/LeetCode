using LeetCode.Infra;
using LeetCode.LeetAgain;
using System;


namespace LeetCode
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Nga nga = new Nga();
            //nga.TryGenerate();

            ISolution sln = new MaximalRectangleSln();
            sln.Execute();

            //StrongLift sl = new StrongLift();
            //sl.PlateCombine(130,5);


            Console.ReadLine();
        }
    }


}