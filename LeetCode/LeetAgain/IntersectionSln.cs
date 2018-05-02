using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode.LeetAgain
{
    class IntersectionSln : ISolution
    {
        public int[] Intersection(int[] nums1, int[] nums2)
        {
            HashSet<int> hs = new HashSet<int>();
            HashSet<int> result = new HashSet<int>();
            foreach (int i in nums1)
            {
                hs.Add(i);
            }

            foreach (var i in nums2)
            {
                if(hs.Contains(i))
                    result.Add(i);
            }

            return result.ToArray();
        }

        public void Execute()
        {
            throw new NotImplementedException();
        }
    }
}