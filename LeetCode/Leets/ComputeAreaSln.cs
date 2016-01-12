using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Leets
{
    class ComputeAreaSln : ISolution
    {
        public int ComputeArea(int A, int B, int C, int D, int E, int F, int G, int H)
        {
            //            int cross

            int horizontalCross = Math.Min(Math.Abs(A - G), Math.Abs(E - C));
            int verticalCorss = Math.Min(Math.Abs(B - H), Math.Abs(D - F));

            return horizontalCross * verticalCorss;
        }
        public void Execute()
        {
            Console.WriteLine(ComputeArea(-3,0,3,4,0,-1,9,2));
//            Console.WriteLine(ComputeArea(-2,-2,2,2,-2,-2,2,2));
        }
    }
}
