using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.LeetAgain
{
    class NumRescueBoatsSln : ISolution
    {
        public int NumRescueBoats(int[] people, int limit)
        {
            //greedy
            Array.Sort(people);
            int count = 0;
            Dictionary<int, int> sDict = new Dictionary<int, int>();

            for (int i = 0; i < people.Length; i++)
            {
                if (sDict.ContainsKey(people[i]))
                {
                    sDict[people[i]] += 1;
                }
                else
                {
                    sDict.Add(people[i], 1);
                }
            }

            for (int i = 0; i < people.Length; i++)
            {
                if (sDict[people[i]] > 0)
                {
                    int target = limit - people[i];
                    bool foundMatch = false;
                    for (int j = people.Length - 1; j >= 0; j--)
                    {
                        if (sDict[people[j]] > 0 && people[j] <= target)
                        {
                            foundMatch = true;
                            count++;
                            sDict[people[j]] -= 1;
                            break;
                        }
                    }

                    if (!foundMatch)
                    {
                        count++;
                    }
                }

                sDict[people[i]] -= 1;
            }

            return count;
        }
        public void Execute()
        {
            NumRescueBoats(new[] {1,2,2,3}, 3);
            NumRescueBoats(new[] {1, 2, 3, 4, 5, 6, 7, 8}, 9);
            NumRescueBoats(new[] { 11, 12, 13, 14, 15, 16, 17, 18 }, 19);
        }
    }
}
