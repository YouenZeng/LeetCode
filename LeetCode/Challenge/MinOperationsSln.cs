﻿using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace LeetCode.Challenge
{
    class MinOperationsSln : ISolution
    {
        public int MinOperations(int[] nums, int x)
        {
            int r = Dfs(nums, 0, nums.Length - 1, x, 0, 0);
            if (r >= 100001)
            {
                return -1;
            }

            return r;
        }


        private int Dfs(int[] nums, int left, int right, int x, int sum, int step)
        {
            if (left == right)
            {
                return 100001;
            }

            if (sum + nums[left] == x || sum + nums[right] == x)
            {
                return 1 + step;
            }

            if (sum + nums[left] > x)
            {
                return 100001;
            }

            if (sum + nums[right] > x)
            {
                return 100001;
            }

            int leftSum = Dfs(nums, left + 1, right, x, sum + nums[left], step + 1);
            int rightSum = Dfs(nums, left, right - 1, x, sum + nums[right], step + 1);



            return Math.Min(leftSum, rightSum);
        }


        public void Execute()
        {
            MinOperations(new[] { 1241, 8769, 9151, 3211, 2314, 8007, 3713, 5835, 2176, 8227, 5251, 9229, 904, 1899, 5513, 7878, 8663, 3804, 2685, 3501, 1204, 9742, 2578, 8849, 1120, 4687, 5902, 9929, 6769, 8171, 5150, 1343, 9619, 3973, 3273, 6427, 47, 8701, 2741, 7402, 1412, 2223, 8152, 805, 6726, 9128, 2794, 7137, 6725, 4279, 7200, 5582, 9583, 7443, 6573, 7221, 1423, 4859, 2608, 3772, 7437, 2581, 975, 3893, 9172, 3, 3113, 2978, 9300, 6029, 4958, 229, 4630, 653, 1421, 5512, 5392, 7287, 8643, 4495, 2640, 8047, 7268, 3878, 6010, 8070, 7560, 8931, 76, 6502, 5952, 4871, 5986, 4935, 3015, 8263, 7497, 8153, 384, 1136 }, 894887480);
            MinOperations(new[] {1, 1, 4, 2, 3}, 5);
            MinOperations(new[] {5, 6, 7, 8, 9}, 4);
        }
    }
}