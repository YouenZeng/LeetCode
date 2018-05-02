using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.LeetAgain
{
    class IntersectIISln : ISolution
    {
        public int[] Intersect(int[] nums1, int[] nums2)
        {
            Array.Sort(nums1);
            Array.Sort(nums2);

            List<int> result = new List<int>();

            int num1Pointer = 0;
            int num2Pointer = 0;

            while (num1Pointer < nums1.Length && num2Pointer < nums2.Length)
            {
                if (nums1[num1Pointer] > nums2[num2Pointer])
                {
                    num2Pointer++;
                    continue;
                }

                if (nums1[num1Pointer] < nums2[num2Pointer])
                {
                    num1Pointer++;
                    continue;
                }


                if (nums1[num1Pointer] == nums2[num2Pointer])
                {
                    result.Add(nums1[num1Pointer]);
                    num1Pointer++;
                    num2Pointer++;
                }
            }

            return result.ToArray();
        }

        public void Execute()
        {
            Intersect(new int[] {1, 2, 2, 1}, new[] {2, 2});
        }
    }
}