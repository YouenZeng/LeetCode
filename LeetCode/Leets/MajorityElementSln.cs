using System;

namespace LeetCode.Leets
{
    public class MajorityElementSln : ISolution
    {

        //Given an array of size n, find the majority element. The majority element is the element that appears more than ⌊ n/2 ⌋ times.
        //
        //You may assume that the array is non-empty and the majority element always exist in the array.
        public int MajorityElement(int[] nums)
        {
            int major = nums[0];
            int count = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (count == 0)
                {
                    major = nums[i];
                    count = 1;
                }
                else
                {
                    count += (nums[i] == major) ? 1 : -1;
                }
            }
            return major;
        }

        public int MajorityElementBit(int[] nums)
        {
            int major = nums[0];
            for (int i = 0, mask = 1; i < 32; i++, mask <<= 1)
            {
                int bitCouns = 0;
                for (int j = 0; j < nums.Length; j++)
                {
                    if ((nums[j] & mask) > 0) bitCouns++;
                    if (bitCouns > nums.Length / 2)
                    {
                        major |= mask;
                        break;
                    }
                }
            }
            return major;
        }


        public void Execute()
        {
            int[] arr = new[] { 1, 23, 4, 5, 6, 1, 1, 1, 1, 1 };
            Console.WriteLine(MajorityElementBit(arr));
        }
    }
}
