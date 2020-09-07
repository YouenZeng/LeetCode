using System.Collections.Generic;
using System.Linq;

namespace LeetCode.LeetAgain
{
    public class PascalTriangleIISln : ISolution
    {
        public IList<int> Generate(int rowIndex)
        {
            int[] arr = new int[rowIndex + 1];

            arr[0] = 1;

            for (int i = 1; i <= rowIndex; i++)
            {
                for (int j = i; j >= 1; j--)
                {
                    arr[j] = arr[j] + arr[j - 1];
                }
            }


            return arr.ToList();
        }

        public void Execute()
        {
            Generate(3);
        }
    }
}