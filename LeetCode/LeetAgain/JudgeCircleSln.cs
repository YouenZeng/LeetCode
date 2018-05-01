using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.LeetAgain
{
    class JudgeCircleSln : ISolution
    {
        public bool JudgeCircle(string moves)
        {
            int udCount = 0;
            int lrCount = 0;

            foreach (char move in moves)
            {
                if (move == 'U')
                    udCount++;
                if (move == 'D')
                    udCount--;
                if (move == 'L')
                    lrCount++;
                if (move == 'R')
                    lrCount--;
            }

            return udCount == 0 && lrCount == 0;
        }

        public void Execute()
        {
            throw new NotImplementedException();
        }
    }
}