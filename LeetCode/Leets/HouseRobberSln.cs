using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Leets
{
    class HouseRobberSln : ISolution
    {
        public int Rob(int[] nums)
        {
            int prevNo = 0;
            int prevYes = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                int tmp = prevNo;
                prevNo = Math.Max(prevNo, prevYes);
                prevYes = nums[i] + tmp;
            }
            return Math.Max(prevYes, prevNo);
        }
        public void Execute()
        {
            Console.WriteLine(Rob(new []{1,2,3,3,200,500}));
        }
    }
}
