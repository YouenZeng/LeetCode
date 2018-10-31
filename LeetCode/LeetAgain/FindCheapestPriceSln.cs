using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.LeetAgain
{
    class FindCheapestPriceSln : ISolution
    {
        class Vetex
        {
            public int Weight { get; set; }
            public bool Visited { get; set; }
            public List<Vetex> Child { get; set; }
        }
        public int FindCheapestPrice(int n, int[][] flights, int src, int dst, int K)
        {
            //if there's no limit
            List<Vetex> vetices = new List<Vetex>();

            for (int i = 0; i < flights.GetLength(0); i++)
            {

            }
            throw new NotImplementedException();
        }
        public void Execute()
        {
            throw new NotImplementedException();
        }
    }
}
