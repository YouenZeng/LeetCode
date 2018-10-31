using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.LeetAgain
{
    class CanPartitionSln : ISolution
    {
        public bool CanPartition(int[] nums)
        {
            int numsLength = nums.Length;
            if (numsLength == 0) return false;
            int sum = 0;
           
            for (int i = 0; i < numsLength; i++)
            {
                sum += nums[i];
            }

            if (sum % 2 != 0) return false;

            int mid = sum / 2;

            int tempSum = 0;
            for (int i = 0; i < numsLength; i++)
            {
                tempSum += nums[i];

                if (tempSum == mid) return true;

                if (tempSum >= mid) continue;

                for (int j = i + 1; j < numsLength; j++)
                {
                    int tTemp = 0;
                    for (int k = j; k < numsLength && tempSum + tTemp <= mid; k++)
                    {
                        tTemp += nums[k];
                        if (tempSum + tTemp == mid) return true;
                    }
                }
            }

            return false;
        }

        public void Execute()
        {
            Console.WriteLine(CanPartition(new[]
            {
                19, 33, 38, 60, 81, 49, 13, 61, 50, 73, 60, 82, 73, 29, 65, 62, 53, 29, 53, 86, 16, 83, 52, 67, 41, 53,
                18, 48, 32, 35, 51, 72, 22, 22, 76, 97, 68, 88, 64, 19, 76, 66, 45, 29, 95, 24, 95, 29, 95, 76, 65, 35,
                24, 85, 95, 87, 64, 97, 75, 88, 88, 65, 43, 79, 6, 5, 70, 51, 73, 87, 76, 68, 56, 57, 69, 77, 22, 27,
                29, 12, 55, 58, 18, 30, 66, 53, 53, 81, 94, 76, 28, 41, 77, 17, 60, 32, 62, 62, 88, 61
            }));
            Console.WriteLine(CanPartition(new[] {1, 5, 11, 5}));
        }
    }
}