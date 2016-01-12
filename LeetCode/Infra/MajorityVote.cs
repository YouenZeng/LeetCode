using System;
using System.Collections.Generic;
using LeetCode.Leets;

namespace LeetCode.Infra
{
    class MajorityVote : ISolution
    {
        public IList<int> MajorityElement(int[] nums)
        {
            IList<int> result = new List<int>();

            if (nums.Length ==1)
            {
                return nums;
            }

            int candicate1 = nums[0];
            int candicate2 = nums[0];

            int count1 = 0;
            int count2 = 0;


            for (int i = 0; i < nums.Length; i++)
            {
                if (count1 == 0)
                {
                    candicate1 = nums[i];
                    count1 = 1;
                }
                else if (count2 == 0 && nums[i] != candicate1)
                {
                    candicate2 = nums[i];
                    count2 = 1;
                }
                else
                {
                    if (nums[i] == candicate1 )
                    {
                        count1++;
                    }
                    else if (nums[i] == candicate2)
                    {
                            count2++;
                    }
                    else
                    {
                        count1--;
                        count2--;
                    }
                }
            }

            count1 = 0;
            count2 = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] == candicate1)
                    count1++;

                if (nums[i] == candicate2)
                    count2++;
            }

            if (count1 > nums.Length / 3)
            {
                result.Add(candicate1);
            }
            if (count2 > nums.Length / 3 && candicate1!= candicate2)
            {
                result.Add(candicate2);
            }
            return result;
        }

        public void Execute()
        {
            int[] nums = { 2, 2,3 };
            Console.WriteLine(MajorityElement(nums));
        }
    }
}
