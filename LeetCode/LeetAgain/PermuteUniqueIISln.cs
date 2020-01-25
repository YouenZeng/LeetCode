using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.LeetAgain
{
    class PermuteUniqueIISln : ISolution
    {
        public IList<IList<int>> PermuteUnique(int[] nums)
        {
            List<IList<int>> result = new List<IList<int>>();


            if (nums == null || nums.Length == 0x0)
                return result;
            Array.Sort(nums);
            List<int> temp = new List<int>();
            bool[] visited = new bool[nums.Length];
            Dfs(nums, result, visited, temp);

            return result;
        }

        private void Dfs(int[] nums, List<IList<int>> result, bool[] visited, IList<int> current)
        {
            if (current.Count == nums.Length)
            {
                result.Add(new List<int>(current));
            }

            for (int i = 0; i < nums.Length; i++)
            {
                if (visited[i])
                    continue;

                if (i > 0 && nums[i - 1] == nums[i] && !visited[i - 1])
                    continue;

                visited[i] = true;
                current.Add(nums[i]);
                Dfs(nums, result, visited, current);
                current.RemoveAt(current.Count - 1);
                visited[i] = false;
            }
        }

        public void Execute()
        {
            PermuteUnique(new int[] { 2, 1, 1 });
        }
    }
}