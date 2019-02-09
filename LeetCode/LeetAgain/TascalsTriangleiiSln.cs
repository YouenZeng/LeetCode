using System.Collections.Generic;
using System.Linq;

namespace LeetCode.LeetAgain
{
    internal class TascalsTriangleiiSln : ISolution
    {
        public IList<int> GetRow(int rowIndex)
        {
            if (rowIndex == 0) return new List<int>() { 1 };

            int[] arr = new int[rowIndex + 1];
            arr[0] = 1;
            for (int i = 1; i <= rowIndex; i++)
            {
                arr[i] = 1;
                for (int j = i - 1; j > 0; j--)
                {
                    arr[j] = arr[j - 1] + arr[j];
                }
            }
            return arr.ToList();
        }
        public void Execute()
        {
            GetRow(3);
        }
    }
}
