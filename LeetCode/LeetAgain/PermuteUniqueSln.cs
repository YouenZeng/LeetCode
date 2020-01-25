using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.LeetAgain
{
    class PermuteUniqueSln : ISolution
    {
        private IList<IList<int>> result = new List<IList<int>>();
        public IList<IList<int>> PermuteUnique(int[] nums)
        {
            IList<int> t = new List<int>();
            HashSet<int> visited = new HashSet<int>();
            HashSet<string> visitedStr = new HashSet<string>();
            string current = string.Empty;
            Dfs(nums, visited, t, visitedStr, current);
            return result;
        }

        private void Dfs(int[] nums, HashSet<int> visited, IList<int> t, HashSet<string> visitedStr, string current)
        {
            if (visited.Count == nums.Length)
            {
                result.Add(new List<int>(t));
            }

            for (int i = 0; i < nums.Length; i++)
            {
                string str = nums[i].ToString();
                string newStr = current + str;
                if (!visited.Contains(i) && !visitedStr.Contains(newStr))
                {
                    visited.Add(i);
                    visitedStr.Add(newStr);
                    t.Add(nums[i]);
                    Dfs(nums, visited, t, visitedStr, newStr);
                    t.RemoveAt(t.Count - 1);
                    visited.Remove(i);
                }
            }
        }


        public void Execute()
        {
            PermuteUnique(new int[] { 2, 1, 1 });
        }
    }
}
