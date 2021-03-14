using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Challenge
{
    class ArrayStringsAreEqualSln : ISolution
    {
        public bool ArrayStringsAreEqual(string[] word1, string[] word2)
        {
            //1. check length equals
            //2. dict? array

            int w1Count = 0;
            int w2Count = 0;

            int w1RowCount = word1.Length;
            int w2RowCount = word2.Length;

            int w1RowIndex = 0;
            int w2RowIndex = 0;

            int w1ColCount = word1[0].Length;
            int w2ColCount = word2[0].Length;

            int w1ColIndex = 0;
            int w2ColIndex = 0;

            while (w1RowIndex < w1RowCount && w2RowIndex < w2RowCount)
            {
                if (word1[w1RowIndex][w1ColIndex] != word2[w2RowIndex][w2ColIndex])
                {
                    return false;
                }
                w1ColIndex++;
                w2ColIndex++;

                if (w1ColIndex == word1[w1RowIndex].Length)
                {
                    w1RowIndex++;
                    w1ColIndex = 0;
                   
                }
                if (w2ColIndex == word2[w2RowIndex].Length)
                {
                    w2RowIndex++;
                    w2ColIndex = 0;
                }
            }

            return w1RowIndex == w1RowCount && w2RowIndex == w2RowCount && w1ColIndex == 0 && w2ColIndex == 0;
        }
        public void Execute()
        {
            ArrayStringsAreEqual(new string[] { "ab", "c" }, new string[] { "a", "bc" });
        }
    }
}
