using System;

namespace LeetCode.Challenge
{
    class IncreasingTripletSln : ISolution
    {
        public bool IncreasingTriplet(int[] nums)
        {
            bool result = false;
            long smallest = nums[0];
            long secondSmallest = int.MaxValue;
            for (int i = 1; i < nums.Length; i++)
            {
                if (nums[i] < smallest)
                {
                    smallest = nums[i];
                }
                if (nums[i] > smallest)
                {
                    secondSmallest = Math.Min(secondSmallest, nums[i]);
                }
                if (nums[i] > secondSmallest)
                {
                    return true;
                }
            }

            return result;
        }
        public void Execute()
        {
            Console.WriteLine(IncreasingTriplet(new int[] { 5, 4, 3, 2, 1 }));
            Console.WriteLine(IncreasingTriplet(new int[] { 1, 2, 3, 4, 6 }));
            Console.WriteLine(IncreasingTriplet(new int[] { 0, 2, 1 }));
            Console.WriteLine(IncreasingTriplet(new int[] { 0, 2, 1, 7 }));
        }
    }
}
