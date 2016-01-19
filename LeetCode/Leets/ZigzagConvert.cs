using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Leets
{
    class ZigzagConvert : ISolution
    {
        public string Convert(string s, int numRows)
        {
            int loop = 2 * numRows - 2;
            if (numRows == 1) return s;
            int columnsCount = s.Length / loop;
            if (s.Length % loop != 0) columnsCount++;

            string[] result = new string[numRows];

            for (int i = 0; i < numRows; i++)
            {
                for (int j = 0; j <= columnsCount; j++)
                {
                    var columnValue = j * loop + i;
                    var midCount = j * loop - i;
                    if (midCount > i && midCount < j * loop && midCount % (numRows - 1) != 0 && midCount<s.Length)
                    {
                        result[i] += s[midCount];
                    }
                    if (columnValue < s.Length)
                    {
                        result[i] += s[columnValue];
                    }

                }
            }

            return string.Join("", result);
        }
        public void Execute()
        {
            Convert("PAYPALISHIRING", 3);
        }
    }
}
