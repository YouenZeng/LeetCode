using System.Collections.Generic;
using System.Linq;

namespace LeetCode.LeetAgain
{
    internal class ReconstructQueueSln : ISolution
    {
        public int[,] ReconstructQueue(int[,] people)
        {
            SortedDictionary<int, List<int>> peopleDict = new SortedDictionary<int, List<int>>();

            for (int i = 0; i < people.GetLength(0); i++)
            {
                if (peopleDict.ContainsKey(people[i, 0]))
                {
                    peopleDict[people[i, 0]].Add(people[i, 1]);
                }
                else
                {
                    peopleDict.Add(people[i, 0], new List<int>() { people[i, 1] });
                }
            }

            SortedSet<int> inQueue = new SortedSet<int>();

            int[,] result = new int[people.GetLength(0), 2];
            foreach (KeyValuePair<int, List<int>> item in peopleDict)
            {
                List<int> positionList = item.Value;
                IOrderedEnumerable<int> pp = positionList.OrderByDescending(p => p);
                foreach (int position in pp)
                {
                    int p = position;
                    foreach (int q in inQueue)
                    {
                        if (p >= q) p++;
                    }
                    result[p, 0] = item.Key;
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
