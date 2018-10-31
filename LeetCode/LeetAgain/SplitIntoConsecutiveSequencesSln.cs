using System;
using System.Collections.Generic;

namespace LeetCode.LeetAgain
{
    class SplitIntoConsecutiveSequencesSln : ISolution
    {
        public bool IsPossible(int[] nums)
        {
            Dictionary<int, int> frequency = new Dictionary<int, int>();
            Dictionary<int, int> appendFrequency = new Dictionary<int, int>();

            foreach (var num in nums)
            {
                if (frequency.ContainsKey(num))
                {
                    frequency[num]++;
                }
                else
                {
                    frequency.Add(num, 1);
                    appendFrequency.Add(num, 0);
                }
            }

            foreach (var num in nums)
            {
                if (frequency[num] == 0) continue;

                //move frequency to next one
                if (appendFrequency[num] > 0)
                {
                    appendFrequency[num] = appendFrequency[num] - 1;
                    if (appendFrequency.ContainsKey(num + 1) == false) appendFrequency.Add(num + 1, 0);
                    appendFrequency[num + 1] = appendFrequency[num + 1] + 1;
                }

                //start
                else if (frequency.ContainsKey(num + 1) && frequency.ContainsKey(num + 2) && frequency[num + 1] > 0 && frequency[num + 2] > 0)
                {
                    frequency[num + 1] = frequency[num + 1] - 1;
                    frequency[num + 2] = frequency[num + 2] - 1;
                    if (appendFrequency.ContainsKey(num + 3) == false) appendFrequency.Add(num + 3, 0);
                    appendFrequency[num + 3] = appendFrequency[num + 3] + 1;
                }
                else
                {
                    return false;
                }

                frequency[num] = frequency[num] - 1;
            }

            return true;
        }
        public void Execute()
        {
            IsPossible(new int[] { 1, 2, 3, 3, 4, 5 });
        }
    }
}
