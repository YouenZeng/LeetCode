using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Leets
{
    class PascalTriangleSln : ISolution
    {
        public IList<IList<int>> Generate(int numRows)
        {
            IList<IList<int>> result = new List<IList<int>>();

            if (numRows == 0) return result;

            result.Add(new List<int>() { 1 });
            if (numRows == 1) return result;

            int prevIndex = 0;
            for (int i = 1; i < numRows; i++)
            {
                var lst = result[prevIndex];
                List<int> tmp = new List<int>();
                tmp.Add(1);

                int prevItem = lst[0];
                for (int j = 1; j < lst.Count; j++)
                {
                    tmp.Add(prevItem + lst[j]);
                    prevItem = lst[j];
                }
                tmp.Add(1);
                result.Add(tmp);
                prevIndex = i;
            }
            return result;
        }
        public void Execute()
        {
            Generate(5);
        }
    }
}
