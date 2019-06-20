using System;

namespace LeetCode.LeetAgain
{
    class FindMedianSortedArraysSln : ISolution
    {
        public double FindMedianSortedArrays(int[] nums1, int[] nums2)
        {
            int m = nums1.Length;
            int n = nums2.Length;
            int total = m + n;
            //如果奇数，则返回第total/2+1小
            if ((total & 0x01) == 1)
                return FindKth(nums1, 0, m, nums2, 0, n, total / 2 + 1);
            //如果为偶数，则返回total/2和total/2+1平均值
            else
                return (FindKth(nums1, 0, m, nums2, 0, n, total / 2) +
                        FindKth(nums1, 0, m, nums2, 0, n, total / 2 + 1)) / 2;
        }

        private double FindKth(int[] nums1, int num1Start, int num1End, int[] nums2, int num2Start, int num2End,
            int targetIndex)
        {
            //假定m<num2End
            if (num1End > num2End)
                return FindKth(nums2, num2Start, num2End, nums1, num1Start, num1End, targetIndex);
            if (num1End == 0)
                return nums2[num2Start + targetIndex - 1];
            if (targetIndex == 1)
                return Math.Min(nums1[num1Start], nums2[num2Start]);
            int stepNum1 = Math.Min(targetIndex / 2, num1End);
            int stepNum2 = targetIndex - stepNum1;
            //System.out.println("num1End = " + num1End + " num2End = " + num2End + " num1Start = " + num1Start + " num2Start = " + num2Start + " targetIndex = " + targetIndex + " pa = " + pa + " pb = " + pb + " " + nums1[pa-1] + " " + nums2[pb-1]);
            if (nums1[num1Start + stepNum1 - 1] < nums2[num2Start + stepNum2 - 1])
                return FindKth(nums1, num1Start + stepNum1, num1End - stepNum1, nums2, num2Start, num2End, targetIndex - stepNum1);
            if (nums1[num1Start + stepNum1 - 1] > nums2[num2Start + stepNum2 - 1])
                return FindKth(nums1, num1Start, num1End, nums2, num2Start + stepNum2, num2End - stepNum2, targetIndex - stepNum2);
            return nums1[num1Start + stepNum1 - 1];
        }

        public void Execute()
        {
            FindMedianSortedArrays(new[] {1, 2}, new[] {-1, 3});
            FindMedianSortedArrays(new[] {1, 2}, new[] {3, 4});
            FindMedianSortedArrays(new[] {1}, new[] {2, 3});
            FindMedianSortedArrays(new[] {1, 3, 5, 6, 7, 8, 9}, new[] {100, 101, 102});
            FindMedianSortedArrays(new[] {1, 3, 5, 6, 7, 8}, new[] {100, 101, 102});
        }
    }
}