using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetCode.LeetAgain
{
    class SubsetsWithDupSln : ISolution
    {
        public void Execute()
        {
            var rr = SubsetsWithDup(new[] { 1, 2, 2 });
        }

        public IList<IList<int>> SubsetsWithDup(int[] nums)
        {
            //https://leetcode.com/problems/subsets-ii/description/

            Array.Sort(nums);

            IList<IList<int>> result = new List<IList<int>>();

            Dfs(nums, 0, new List<int>(), result);

            return result;
        }

        private void Dfs(int[] nums, int startIndex, List<int> path, IList<IList<int>> result)
        {
            result.Add(path);

            for (int i = startIndex; i < nums.Length; i++)
            {
                if (i > startIndex && nums[i] == nums[i - 1]) continue;

                List<int> nPath = new List<int>(path);
                nPath.Add(nums[i]);

                Dfs(nums, i + 1, nPath, result);
            }
        }
    }
}
