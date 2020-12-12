using System;
using System.Threading;
using System.Threading.Tasks;
using LeetCode.Challenge;
using LeetCode.LeetAgain;
using LeetCode.Leets;

namespace LeetCode
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ISolution sln = new Challenge.ValidMountainArraySln();
            sln.Execute();


            Console.ReadLine();
        }
    }

    public class ThreadTest
    {
        private ManualResetEvent manualResetEventSlim = new ManualResetEvent(false);
        private AutoResetEvent ars = new AutoResetEvent(true);

        public void Go()
        {
            //manualResetEventSlim.Reset();

            Task.Run(() =>
            {
                manualResetEventSlim.WaitOne();
                Console.WriteLine("In task.");

                manualResetEventSlim.WaitOne();
                Console.WriteLine("In task2.");
            });

            Task.Run(() =>
            {
                manualResetEventSlim.WaitOne();
                Console.WriteLine("Innnnnnn task.");

                manualResetEventSlim.WaitOne();
                Console.WriteLine("Innnnnnn task2.");
            });

            Thread.Sleep(2000);
            Console.WriteLine("Set slim");
            manualResetEventSlim.Set();
        }
    }
}