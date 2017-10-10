using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.LeetAgain
{
    public class MajorityElementSln : ISolution
    {
        public int MajorityElement(int[] nums)
        {
            int count = 0, ret = 0;
            foreach (int num in nums)
            {
                if (count == 0)
                    ret = num;
                if (num != ret)
                    count--;
                else
                    count++;
            }
            return ret;
        }
        public void Execute()
        {
            throw new NotImplementedException();
        }
    }
}
