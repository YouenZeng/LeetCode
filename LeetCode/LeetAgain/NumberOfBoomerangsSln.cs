using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.LeetAgain
{
    public class NumberOfBoomerangsSln : ISolution
    {
        public int NumberOfBoomerangs(int[,] points)
        {
            int pointLength = points.GetLength(0);
            int result = 0;
            for (int i = 0; i < pointLength; i++)
            {
                Dictionary<int, int> dict = new Dictionary<int, int>();
                for (int j = 0; j < pointLength; j++)
                {
                    if (i == j)
                        continue;

                    int distance = CalcDistance(points[i, 0], points[i, 1], points[j, 0], points[j, 1]);

                    if (dict.ContainsKey(distance) == false)
                        dict.Add(distance, 1);
                    else
                    {
                        dict[distance]++;
                    }
                }
                foreach (KeyValuePair<int, int> keyValuePair in dict)
                {
                    result += keyValuePair.Value * (keyValuePair.Value - 1);
                }
                dict.Clear();
            }
            return result;
        }

        private int CalcDistance(int x1, int y1, int x2, int y2)
        {
            return (x1 - x2) * (x1 - x2) + (y1 - y2) * (y1 - y2);
        }
        public void Execute()
        {
            NumberOfBoomerangs(new int[,]
            {
                {0,0},
                {1,0 },
                {2,0 }
            });
        }
    }
}
