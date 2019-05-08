using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.LeetAgain
{
    internal class KthGrammarSln : ISolution
    {
        public int KthGrammar(int N, int K)
        {
            if (N == 1) return 0;
            if (K % 2 == 0) return (KthGrammar(N - 1, K / 2) == 0) ? 1 : 0;
            return (KthGrammar(N - 1, (K + 1) / 2) == 0) ? 0 : 1;
        }

        public void Execute()
        {
            KthGrammar(1, 1);
            KthGrammar(2, 1);
            KthGrammar(2, 2);
            KthGrammar(4, 5);
            KthGrammar(4, 6);
        }
    }
}