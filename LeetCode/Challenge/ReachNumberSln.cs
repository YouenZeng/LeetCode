using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Challenge
{
    class ReachNumberSln : ISolution
    {
        public int ReachNumber(int target)
        {
            target = Math.Abs(target);
            int k = 0;
            while (target > 0)
            {
                target -= ++k;
            }

            return target % 2 == 0 ? k : k + 1 + k % 2;
        }

        private int Reach(int target)
        {
            throw new NotImplementedException();
        }

        public void Execute()
        {
            throw new NotImplementedException();
        }
    }
}
