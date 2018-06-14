using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.LeetAgain
{
    class ZigZagConversionSln : ISolution
    {
        public string Convert(string s, int numRows)
        {
            if (string.IsNullOrEmpty(s)) return s;
            if (numRows == 1) return s;
            StringBuilder sb = new StringBuilder();
            int slength = s.Length;
            int zigZagSize = numRows + numRows - 2;

            int zigZagCount = slength / zigZagSize;

            if (slength % zigZagSize != 0) zigZagCount++;

            for (int i = 0; i < numRows; i++)
            {
                for (int j = 0; j < zigZagCount; j++)
                {

                    if ((j * zigZagSize + i) < slength)
                    {
                        sb.Append(s[j * zigZagSize + i]);
                    }

                    if (i != 0 && i != numRows - 1)
                    {

                        if ((j * zigZagSize + zigZagSize - i) < slength)
                        {
                            sb.Append(s[j * zigZagSize + zigZagSize - i]);
                        }
                    }
                }
            }
            return sb.ToString();
        }
        public void Execute()
        {
            //
            Console.WriteLine(Convert("PAYPALISHIRING", 4));
        }
    }
}
