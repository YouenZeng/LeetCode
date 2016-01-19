using System;
using System.Collections.Generic;

namespace LeetCode.Leets
{
    class SubsetsSln : ISolution
    {
        public IList<IList<int>> Subsets(int[] nums)
        {
            //添加数字构建subset 

            IList<IList<int>> result = new List<IList<int>>();

            IList<int> current = new List<int>();

            Array.Sort(nums);
            result.Add(current);

            for (int i = 0; i < nums.Length; i++)
            {
                int resultLength = result.Count;

                for (int j = 0; j < resultLength; j++)
                {
                    current = new List<int>(result[j]);
                    current.Add(nums[i]);
                    result.Add(new List<int>(current));
                }
            }
            return result;
        }

        public IList<IList<int>> Subsets2(int[] nums)
        {
            //backtracking

            IList<IList<int>> result = new List<IList<int>>();

            IList<int> current = new List<int>();

            Array.Sort(nums);
            result.Add(current);

            FindAllSets(nums, 0, current, result);

            return result;
        }

        private void FindAllSets(int[] nums, int start, IList<int> lst, IList<IList<int>> result)
        {
            for (int i = start; i < nums.Length; i++)
            {
                lst.Add(nums[i]);
                result.Add(new List<int>(lst));

                FindAllSets(nums, i + 1, lst, result);
                lst.RemoveAt(lst.Count-1 ); //与lst.Add(nums[i])对应
            }
        }

        public void Execute()
        {
            Subsets2(new[] { 1, 2, 3 });
        }
    }
}
