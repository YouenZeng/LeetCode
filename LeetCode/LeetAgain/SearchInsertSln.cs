using System;

namespace LeetCode.LeetAgain
{
    class SearchInsertSln : ISolution
    {
        public int SearchInsert(int[] nums, int target)
        {
            int hi = nums.Length - 1;
            int lo = 0;

            while (lo < hi)
            {
                int mid = (hi + lo) / 2;

                if (nums[mid] < target)
                {
                    lo = mid + 1;
                }
                else
                {
                    hi = mid;
                }
            }

            if (nums[lo] < target)
                return lo + 1;
            return lo;
        }

        public void Execute()
        {
            SearchInsert(new int[] {1, 3, 5, 6}, 5);
            SearchInsert(new int[] {1, 3, 5, 6}, 2);
            SearchInsert(new int[] {1, 3, 5, 6}, 7);
            SearchInsert(new int[] {1, 3, 5, 6}, 0);
            throw new NotImplementedException();
        }
    }
}