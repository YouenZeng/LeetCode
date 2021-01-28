using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Challenge
{
    class CheckArithmeticSubarraysSln : ISolution
    {
        public IList<bool> CheckArithmeticSubarrays(int[] nums, int[] l, int[] r)
        {
            List<bool> result = new List<bool>();

            for (int i = 0; i < l.Length; i++)
            {
                int[] subArray = new int[r[i] - l[i] + 1];
                Array.Copy(nums, l[i], subArray, 0, r[i] - l[i] + 1);

                Array.Sort(subArray);
                int diff = subArray[1] - subArray[0];
                bool isArithmetic = true;
                for (int j = 1; j < subArray.Length; j++)
                {
                    if (subArray[j] - subArray[j - 1] != diff)
                    {
                        isArithmetic = false;
                        break;
                    }
                }

                result.Add(isArithmetic);
            }

            return result;
        }

        public void Execute()
        {
            CheckArithmeticSubarrays(new int[] {4, 6, 5, 9, 3, 7}, new int[] { 0, 0, 2 }, new int[]{ 2, 3, 5 });
        }
    }
}