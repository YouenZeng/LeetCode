namespace LeetCode.LeetAgain
{
    class SearchRangeSln : ISolution
    {
        public int[] SearchRange(int[] nums, int target)
        {
            int hi = nums.Length - 1;
            int lo = 0;

            int[] result = {-1, -1};
            if (nums.Length == 0) return result;
            while (lo < hi)
            {
                int mid = lo + (hi - lo) / 2;

                if (nums[mid] < target)
                    lo = mid + 1;
                else
                {
                    hi = mid;
                }
            }

            if (nums[lo] != target) return result;

            result[0] = lo;

            hi = nums.Length - 1;
            while (lo < hi)
            {
                int mid = lo + (hi - lo) / 2 + 1;
                if (nums[mid] > target)
                {
                    hi = mid - 1;
                }
                else
                {
                    lo = mid;
                }
            }

            result[1] = hi;

            return result;
        }


        public void Execute()
        {
            var r = SearchRange(new int[] {5, 7, 7, 8, 8, 8, 8, 10}, 8);
            r = SearchRange(new int[] {5, 7, 7, 8, 8, 8, 8, 10}, 6);
            r = SearchRange(new int[] {1, 1, 1}, 1);
            r = SearchRange(new int[] {1, 1}, 1);
            r = SearchRange(new int[] {0, 1}, 1);
        }
    }
}