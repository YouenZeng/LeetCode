using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.LeetAgain
{
    internal class KthGrammarSln : ISolution
    {
        public int KthGrammar(int N, int K)
        {
            int[] indexHistory = new int[32];
            for (int i = 0; i < 32; i++)
            {
                indexHistory[i] = -1;
            }
            //to 0 based index
            K = K - 1;
            N = N - 1;
            while (N >= 0)
            {
                indexHistory[N] = K;
                K = K / 2;
                N--;
            }

            int result = indexHistory[0];
            
            for (int i = 1; i < 32; i++)
            {
                if (indexHistory[i] == -1)
                    break;

                if (result == 0)
                {
                    result = (indexHistory[i] % 2);
                    continue;
                }
                if (result == 1)
                {
                    result = ((indexHistory[i] + 1) % 2);
                    continue;
                }
            }

            Console.WriteLine(result);
            return result;
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
