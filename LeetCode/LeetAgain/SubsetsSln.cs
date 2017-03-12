using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.LeetAgain
{
    class SubsetsSln : ISolution
    {
        public IList<IList<int>> Subsets(int[] nums)
        {
            IList<IList<int>> result = new List<IList<int>>();
            Backtracking(result, new List<int>(), nums, 0);
            return result;
        }

        private void Backtracking(IList<IList<int>> list, IList<int> tempResult, int[] nums, int start)
        {
            list.Add(new List<int>(tempResult));

            for (int i = start; i < nums.Length; i++)
            {
                tempResult.Add(nums[i]);
                Backtracking(list, tempResult, nums, i + 1);
                tempResult.RemoveAt(tempResult.Count - 1);
            }
        }

        public void Execute()
        {
            Subsets(new[] { 1, 2, 3 });
        }
    }
}
