using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace LeetCode.LeetAgain
{
    class TopKFrequentSln : ISolution
    {
        public IList<int> TopKFrequent(int[] nums, int k)
        {
            Dictionary<int, int> numsCount = new Dictionary<int, int>();

            foreach (var item in nums)
            {
                if (numsCount.ContainsKey(item)) numsCount[item]++;
                else numsCount.Add(item, 1);
            }

            List<int>[] bucket = new List<int>[nums.Length + 1];

            foreach (var item in numsCount)
            {
                if (bucket[item.Value] == null)
                {
                    bucket[item.Value] = new List<int>();
                }
                bucket[item.Value].Add(item.Key);
            }

            List<int> result = new List<int>();
            for (int i = bucket.Length - 1; i >= 0 && result.Count < k; i--)
            {
                if (bucket[i]!=null && bucket[i].Count>0)
                {
                    result.AddRange(bucket[i]);
                }
            }

            return result;
            // return numsCount.OrderByDescending(n => n.Value).Take(k).Select(n => n.Key).ToList();

        }
        public void Execute()
        {
            throw new NotImplementedException();
        }
    }
}
