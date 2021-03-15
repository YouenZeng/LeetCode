using System;
using System.Collections.Generic;

namespace LeetCode
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Dijkstra.Go(null);

            ISolution sln = new Challenge.SpiralOrderSln();
            sln.Execute();


            //            int[] arr = new int[] { 3, 5, 3, 0, 8, 6, 1, 5, 8, 6, 2, 4, 9, 4, 7, 0, 1, 8, 9, 7, 3, 1, 2, 5, 9, 7, 4, 0, 2, 6 };
            ////            int[] arr = new int[] { 3, 5, 3 };
            //            HeapSort hs = new HeapSort(arr);
            //            //Infra.HeapSort hs = new Infra.HeapSort(arr);
            //            hs.BuildHeap();

            Console.ReadLine();
        }
    }
}