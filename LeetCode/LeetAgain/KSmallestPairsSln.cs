using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.LeetAgain
{
    class KSmallestPairsSln : ISolution
    {
        public IList<int[]> KSmallestPairs(int[] nums1, int[] nums2, int k)
        {

            int arr1Length = nums1.Length;
            int arr2Length = nums2.Length;
            IList<int[]> result = new List<int[]>();

            var searchIndexer = new List<int>(new int[arr1Length]);
            int currentResult = 0;
            while (currentResult < k)
            {
                int currentNumsIndex = 0;
                int val = int.MaxValue;
                for (int i = 0; i < searchIndexer.Count; i++)
                {
                    //find smallest one
                    if (searchIndexer[i] < arr2Length && nums1[i] + nums2[searchIndexer[i]] < val)
                    {
                        currentNumsIndex = i;
                        val = nums1[i] + nums2[searchIndexer[i]];
                    }
                }

                if (val == int.MaxValue)
                {
                    return result;
                }

                currentResult++;
                result.Add(new int[] { nums1[currentNumsIndex], nums2[searchIndexer[currentNumsIndex]] });
                searchIndexer[currentNumsIndex]++;

            }

            return result;
        }
        public void Execute()
        {
            KSmallestPairs(new int[] { 1, 1, 2 }, new int[] { 1, 2, 3 }, 511);
        }
    }
}
