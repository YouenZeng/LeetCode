using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetCode.LeetAgain
{
    internal class ReconstructQueueSln : ISolution
    {
        public int[,] ReconstructQueue(int[,] people)
        {
            Dictionary<int, List<int>> peopleDict = new Dictionary<int, List<int>>();
            List<int> heightList = new List<int>();
            for (int i = 0; i < people.GetLength(0); i++)
            {
                if (peopleDict.ContainsKey(people[i, 0]))
                {
                    peopleDict[people[i, 0]].Add(people[i, 1]);
                }
                else
                {
                    peopleDict.Add(people[i, 0], new List<int>() { people[i, 1] });
                    heightList.Add(people[i, 0]);
                }
            }

            heightList.Sort();

            SortedSet<int> inQueue = new SortedSet<int>();

            int[,] result = new int[people.GetLength(0), 2];
            foreach (int h in heightList)
            {
                List<int> positionList = peopleDict[h];
                IOrderedEnumerable<int> pp = positionList.OrderByDescending(p => p);
                foreach (int position in pp)
                {
                    int p = position;
                    foreach (int q in inQueue)
                    {
                        if (p >= q) p++;
                    }
                    result[p, 0] = h;
                    result[p, 1] = position;
                    inQueue.Add(p);
                }
            }
            return result;
        }
        public void Execute()
        {
            ReconstructQueue(new int[,] { { 7, 0 }, { 4, 4 }, { 7, 1 }, { 5, 0 }, { 6, 1 }, { 5, 2 } });
        }
    }
}
