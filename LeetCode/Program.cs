using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using DijkstraAlgorithm;

namespace LeetCode
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Dijkstra.Go(null);


            ISolution sln = new Challenge.MajorityElementSln();
            sln.Execute();

            string s = "";

            //PeekingIterator pi = new PeekingIterator((new List<int>() {1, 2, 3}).GetEnumerator());
            //pi.Next();
            //pi.Peek();
            //pi.Next();
            //pi.Next();
            //pi.HasNext();
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