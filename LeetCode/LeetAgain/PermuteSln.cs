using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.LeetAgain
{
    class PermuteSln : ISolution
    {

        private IList<IList<int>> result = new List<IList<int>>();
        public IList<IList<int>> Permute(int[] nums)
        {
            IList<int> t = new List<int>();
            HashSet<int> visited = new HashSet<int>();
            Dfs(nums, visited, t);
            return result;
        }


        private void Dfs(int[] nums, HashSet<int> visited, IList<int> t)
        {
            if (visited.Count == nums.Length)
            {
                result.Add(new List<int>(t));
            }

            for (int i = 0; i < nums.Length; i++)
            {
                if (!visited.Contains(i))
                {
                    visited.Add(i);
                    t.Add(nums[i]);
                    Dfs(nums, visited, t);
                    t.RemoveAt(t.Count - 1);
                    visited.Remove(i);
                }
            }
        }

        public void Execute()
        {
            Permute(new int[] { 1, 2, 3 });
        }
    }
}
