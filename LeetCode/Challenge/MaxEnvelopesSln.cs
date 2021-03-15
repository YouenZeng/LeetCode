using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace LeetCode.Challenge
{
    class MaxEnvelopesSln : ISolution
    {
        public int MaxEnvelopes(int[][] envelopes)
        {
            if (envelopes.Length == 0)
            {
                return 0;
            }

            Array.Sort(envelopes, Comparer<int[]>.Create(((a1, a2) => {
                if (a1[0] == a2[0])
                {
                    return a2[1].CompareTo(a1[1]);
                }

                return a1[0].CompareTo(a2[0]);
            })));

            int len = envelopes.Length;
            int max = 1;
            int[] dp = new int[len];
            Array.Fill(dp, 1);

            for (int i = 1; i < len; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    if (envelopes[i][1] > envelopes[j][1])
                    {
                        dp[i] = Math.Max(dp[i], 1 + dp[j]);
                    }
                }

                max = Math.Max(max, dp[i]);
            }


            return max;
        }

        public int lengthOfLIS(int[] nums)
        {
            int[] tails = new int[nums.Length];
            int size = 0;

            tails[0] = nums[0];
            for (int i = 1; i < nums.Length; i++)
            {
                if (tails[0] > nums[i])
                {
                    tails[0] = nums[i];
                }
                else if (tails[size] <= nums[i])
                {
                    size++;
                    tails[size] = nums[i];
                }
                else
                {
                    tails[BinarySearch(tails, 0, size, nums[i])] = nums[i];
                }
            }

            return 1 + size;
        }

        private int BinarySearch(int[] arr, int from, int to, int value)
        {
            
            while (from < to)
            {
                int mid = from + (to - from) / 2;

                if (arr[mid] < value)
                {
                    from = mid + 1;
                }
                else
                {
                    to = mid ;
                }
            }

            return from;
        }

        public void Execute()
        {
            lengthOfLIS(new[] {10, 9, 2, 5, 3, 7, 101, 18});

            int[][] arr = new int[5][] {
                new int[] {4, 5}, new int[] {4, 6}, new int[] {6, 7}, new int[] {2, 3}, new int[] {1, 1}
            };

            MaxEnvelopes(arr);
        }
    }
}