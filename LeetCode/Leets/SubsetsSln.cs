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
<<<<<<< HEAD
            IList<IList<int>> result = new List<IList<int>>();

=======
            //添加数字构建subset 

            IList<IList<int>> result = new List<IList<int>>();

>>>>>>> bf4ed5a2bd2d1c537991a09e09e1bd285de2d989
            IList<int> current = new List<int>();

            Array.Sort(nums);
            result.Add(current);
<<<<<<< HEAD
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
=======

            for (int i = 0; i < nums.Length; i++)
            {
                int resultLength = result.Count;

                for (int j = 0; j < resultLength; j++)
                {
                    current = new List<int>(result[j]);
                    current.Add(nums[i]);
                    result.Add(new List<int>(current));
>>>>>>> bf4ed5a2bd2d1c537991a09e09e1bd285de2d989
                }
            }
            return result;
        }

<<<<<<< HEAD
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
=======
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
>>>>>>> bf4ed5a2bd2d1c537991a09e09e1bd285de2d989
        }

        public void Execute()
        {
<<<<<<< HEAD
            Stest s = new Stest();

            Subsets(new[] { 1, 2, 2});

            
=======
            Subsets2(new[] { 1, 2, 3 });
>>>>>>> bf4ed5a2bd2d1c537991a09e09e1bd285de2d989
        }
    }

    struct  Stest
    {
        public int Asss { get; set; }
        public int As2ss { get; set; }
        public int As3ss { get; set; }

        
    }
}
