using System;
using System.Collections.Generic;

namespace LeetCode.LeetAgain
{
    public class PascalTriangleSln : ISolution
    {
        public IList<IList<int>> Generate(int numRows)
        {
            IList<IList<int>> result = new List<IList<int>>();
            if (numRows == 0)
                return result;
            List<int> r = new List<int>() {1};
            result.Add(r);

            for (int i = 1; i < numRows; i++)
            {
                var r2 = new List<int>();
                r2.Add(1);
                for (int j = 1; j < r.Count; j++)
                {
                    r2.Add(r[j] + r[j - 1]);
                }

                r2.Add(1);

                result.Add(r2);
                r = r2;
            }

            return result;
        }

        public void Execute()
        {
            Generate(5);
        }
    }
}