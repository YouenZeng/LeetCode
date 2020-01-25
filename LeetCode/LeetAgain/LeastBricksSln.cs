using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetCode.LeetAgain
{
    class LeastBricksSln : ISolution
    {
        public int LeastBricks(IList<IList<int>> wall)
        {
            Dictionary<int, int> dict = new Dictionary<int, int>();

            foreach (IList<int> w in wall)
            {
                int currentB = 0;
                foreach (var b in w)
                {
                    currentB += b;

                    if (dict.ContainsKey(currentB))
                    {
                        dict[currentB] += 1;
                    }
                    else
                    {
                        dict.Add(currentB, 1);
                    }

                   
                }
                dict.Remove(currentB);
            }

            int max = 0;
            foreach (KeyValuePair<int, int> keyValuePair in dict)
            {
                max = Math.Max(max, keyValuePair.Value);
            }

            return wall.Count - max;
        }


        public void Execute()
        {
            IList<IList<int>> lst = new List<IList<int>>
            {
                new List<int> {1, 2, 2, 1}, new List<int> {3, 1, 2}, new List<int> {1, 3, 2},
                new List<int> {2, 4}, new List<int> {3, 1, 2}, new List<int> {1, 3, 1, 1}
            };


            LeastBricks(lst);
        }
    }
}