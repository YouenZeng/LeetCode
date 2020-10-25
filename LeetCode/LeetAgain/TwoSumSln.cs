using System;

namespace LeetCode.LeetAgain
{
    class TwoSumSln : ISolution
    {
        public int[] TwoSum(int[] numbers, int target)
        {
            int slow = 0;
            int fast = numbers.Length - 1;
            int[] result = new int[2];
            while (slow < fast)
            {
                if (numbers[slow] + numbers[fast] < target)
                {
                    slow++;
                }
                else if (numbers[slow] + numbers[fast] > target)
                {
                    fast--;
                }
                else
                {
                    result[0] = ++slow;
                    result[1] = ++fast;
                    return result;
                }
            }

            return result;
        }

        public void Execute()
        {
            Console.WriteLine(TwoSum(new[] {2, 7, 11, 15}, 9));
            Console.WriteLine(TwoSum(new[] {1, 2, 29, 30, 35}, 59));
            Console.WriteLine(TwoSum(new[] {2, 3, 4}, 6));
            Console.WriteLine(TwoSum(new[] {-1, 0}, -1));
        }
    }
}