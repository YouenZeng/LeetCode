using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace LeetCode.Leets
{
    class SubsetsSln : ISolution
    {
        public IList<IList<int>> Subsets(int[] nums)
        {
            IList<IList<int>> result = new List<IList<int>>();

            IList<int> current = new List<int>();

            Array.Sort(nums);
            result.Add(current);
//            GetSubsets(nums, 0, result, current,int.MinValue);

            for (int i = 0; i < nums.Length; i++)
            {
                int dupCount = 0;
                while (((i + 1) < nums.Length) && nums[i + 1] == nums[i])
                {
                    dupCount++;
                    i++;
                }
                int prevNum = result.Count;
                for (int j = 0; j < prevNum; j++)
                {
                    List<int> element = new List<int>(result[j]);
                    for (int t = 0; t <= dupCount; t++)
                    {
                        element.Add(nums[i]);
                        result.Add(new List<int>(element));
                    }
                }
            }
            return result;
        }

        private void GetSubsets(int[] nums, int start, IList<IList<int>> result, IList<int> current,int preValue)
        {
            int numsLength = nums.Length;
            int prev = 0;
            for (int i = start; i < numsLength; i++)
            {
                current.Add(nums[i]);
                result.Add(new List<int>(current));
                GetSubsets(nums, i + 1, result, current, prev);

                prev = current[current.Count - 1];
                
                current.RemoveAt(current.Count - 1);
                
            }
        }

        public IList<IList<int>> BitSubsets(int[] nums)
        {
            int totalCount =1 << nums.Length;
            IList<IList<int>> result = new List<IList<int>>();
            Array.Sort(nums);

            for (int i = 0; i < totalCount; i++)
            {
                IList<int> set = new List<int>();
                for (int j = 0; j < nums.Length; j++)
                {
                    if ((i & (1 << j)) != 0)
                        set.Add(nums[j]);
                }
                result.Add(set);
            }
            return result;
        }

        private IList<int> NumberToSets(int number, int[] nums)
        {
            BitArray b = new BitArray(new[] { number });
            IList<int> result = new List<int>();
            for (int i = 0; i < b.Length; i++)
            {
                if (b[i])
                {
                    result.Add(nums[i]);
                }
            }
            return result;
        }

        public void Execute()
        {
            Stest s = new Stest();

            Subsets(new[] { 1, 2, 2});

            
        }
    }

    struct  Stest
    {
        public int Asss { get; set; }
        public int As2ss { get; set; }
        public int As3ss { get; set; }

        
    }
}
