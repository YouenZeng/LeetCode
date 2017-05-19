using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.LeetAgain
{
    public class HammingDistanceSln : ISolution
    {
        public int HammingDistance(int x, int y)
        {
            int c = x ^ y;
            int result = 0;
            for (int i = 31; i >= 0; i--)
            {
                if (c == 0)
                    break;
                if (c / (1 << i) > 0)
                {
                    result++;
                    c = c % (1 << i);
                }
            }
            return result;
        }
        public void Execute()
        {
            HammingDistance(1, 4);
        }
    }
}
