using System;
using System.Collections.Generic;

namespace LeetCode.LeetAgain
{
    class TopKFrequentSln : ISolution
    {
        public IList<int> TopKFrequentHeapSort(int[] nums, int k)
        {
            throw new NotImplementedException();
        }

        private void HeapSort(int[] nums)
        {
            int n = nums.Length;

            for (int i = n / 2 - 1; i >= 0; i--)
            {
                Heapify(nums, n, i);
            }

            for (int i = n - 1; i >= 0; i--)
            {
                int temp = nums[0];
                nums[0] = nums[i];
                nums[i] = temp;

                Heapify(nums, i, 0);
            }
        }

        private void Heapify(int[] nums, int heapSize, int currentRootIndex)
        {
            int leftIndex = currentRootIndex * 2;
            int rightIndex = leftIndex + 1;

            int largest = currentRootIndex;
            if (leftIndex < heapSize && nums[leftIndex] < nums[currentRootIndex])
            {
                largest = leftIndex;
            }

            if (rightIndex < heapSize && nums[currentRootIndex] < nums[rightIndex])
            {
                largest = rightIndex;
            }

            if (largest != currentRootIndex)
            {
                int swap = nums[currentRootIndex];
                nums[currentRootIndex] = nums[largest];
                nums[largest] = swap;

                Heapify(nums, heapSize, largest);
            }
        }

        /// <summary>
        /// 桶
        /// </summary>
        /// <param name="nums"></param>
        /// <param name="k"></param>
        /// <returns></returns>
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
                if (bucket[i] != null && bucket[i].Count > 0)
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
