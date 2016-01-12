using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Leets
{
    public class SearchInsertSln : ISolution
    {
        //https://leetcode.com/problems/search-insert-position/


        public int SearchInsert(int[] nums, int target)
        {
            if (nums.Length == 0)
                return 0;
            if (target > nums[nums.Length-1])
                return nums.Length;
            if (target < nums[0])
                return 0;
            int currentIndex = 0;
            int previous = nums[0];
            for (int i = 0; i < nums.Length; i++)
            {
                currentIndex = i;

                if (target >= previous && target <= nums[i])
                {
                    break;
                }
            }
            return currentIndex;
        }
        public void Execute()
        {
            int[] arr = { 1,3 };
            int found = 2;
            Console.WriteLine(SearchInsert(arr, found));
        }
    }
}
