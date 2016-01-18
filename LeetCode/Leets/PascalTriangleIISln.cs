using System.Collections.Generic;

namespace LeetCode.Leets
{
    class PascalTriangleIISln : ISolution
    {
        public IList<int> GetRow(int rowIndex)
        {
            int[] result = new int[rowIndex + 1];
            result[0] = 1;
            for (int i = 1; i <= rowIndex; i++)
            {
                for (int j = i; j >= 1; j--)
                {
                     result[j] += result[j - 1];
                }
            }
            return result;
        }
        public void Execute()
        {
            GetRow(3);
        }
    }
}
