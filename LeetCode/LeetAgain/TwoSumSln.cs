using System;
using System.Collections.Generic;
using System.Text;
using LeetCode.Leets;

namespace LeetCode.LeetAgain
{
    class TwoSumSln:ISolution
    {
        public int[] TwoSum(int[] numbers, int target)
        {
            int start = 0;
            int end = numbers.Length-1;
            int[] result = new int[2];
            while (start<end)
            {
                if ((numbers[start] + numbers[end]) > target)
                {
                    end--;
                }
                if ((numbers[start] + numbers[end]) < target)
                {
                    start++;
                }
                if ((numbers[start] + numbers[end]) ==target)
                {
                    result[0] = start + 1;
                    result[1] = end + 1;
                    break;
                }
            }

            return result;
        }
        public void Execute()
        {
            Console.WriteLine(TwoSum(new []{ 2, 7, 11, 15 },9));
        }
    }
}
