using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.LeetAgain
{
    class MirrorReflectionSln : ISolution
    {
        public int MirrorReflection(int p, int q)
        {
            while (q % 2 == 0 && p % 2 == 0)
            {
                q /= 2;
                p /= 2;
            }
            if (q % 2 == 0 && p % 2 == 1) return 0;
            if (q % 2 == 1 && p % 2 == 1) return 1;
            if (q % 2 == 1 && p % 2 == 0) return 2;
            return -1;
        }
        public void Execute()
        {
            throw new NotImplementedException();
        }
    }
}
