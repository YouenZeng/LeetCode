using System;

namespace LeetCode.Challenge
{
    class FindKthPositiveSln : ISolution
    {
        public int FindKthPositive(int[] arr, int k)
        {
            //2 pointers
            int missingCount = 0;
            int prev = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                missingCount += arr[i] - prev - 1;
                if (missingCount >= k)
                {
                    missingCount -= arr[i] - prev - 1;
                    break;
                }

                prev = arr[i];
            }

            return prev + k - missingCount;
        }
        public void Execute()
        {
            FindKthPositive(new int[] { 1, 2, 3, 4 }, 2);
        }
    }
}
