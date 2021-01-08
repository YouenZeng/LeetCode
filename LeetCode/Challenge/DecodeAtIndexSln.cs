using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Challenge
{
    class DecodeAtIndexSln : ISolution
    {
        public string DecodeAtIndex(string S, int K)
        {
            long k = K;
            long currentLength = 0;
            for (int i = 0; i < S.Length; i++)
            {
                if (char.IsLower(S[i]))
                {
                    currentLength++;
                }
                else
                {
                    currentLength *= (S[i] - '0');
                }
            }

            for (int i = S.Length - 1; i >= 0; i--)
            {
                k = k % currentLength;
                if (k == 0 && char.IsLower(S[i]))
                {
                    return S[i].ToString();
                }

                if (char.IsDigit(S[i]))
                {
                    currentLength /= S[i] - '0';
                }
                else
                {
                    currentLength--;
                }
            }

            return string.Empty;
        }
        public void Execute()
        {
            Console.WriteLine(DecodeAtIndex("ajx37nyx97niysdrzice4petvcvmcgqn282zicpbx6okybw93vhk782unctdbgmcjmbqn25rorktmu5ig2qn2y4xagtru2nehmsp", 976159153));
            Console.WriteLine(DecodeAtIndex("leet2code3", 10));
            Console.WriteLine(DecodeAtIndex("ha22", 5));
            Console.WriteLine(DecodeAtIndex("a2345678999999999999999", 1));
        }
    }
}
