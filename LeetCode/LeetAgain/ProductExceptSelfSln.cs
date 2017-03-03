using System;
using LeetCode.Leets;

namespace LeetCode.LeetAgain
{
    public class ProductExceptSelfSln : ISolution
    {
        public int[] ProductExceptSelf(int[] nums)
        {
            // two pointers like

            int n = nums.Length;
            int[] resultArr = new int[n];
            resultArr[0] = 1;
            for (int i = 1; i < n; i++)
            {
                resultArr[i] = resultArr[i - 1] * nums[i - 1];
            }

            int right = 1;
            for (int i = n - 1; i >= 0; i--)
            {
                resultArr[i] *= right;
                right *= nums[i];
            }
            return resultArr;
        }
        void ISolution.Execute()
        {
            ProductExceptSelf(new[] { 1, 2, 3, 4, 5 });
        }
    }
}