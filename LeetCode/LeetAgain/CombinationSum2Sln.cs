using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.LeetAgain
{
    class CombinationSum2Sln : ISolution
    {
        IList<IList<int>> result = new List<IList<int>>();

        public IList<IList<int>> CombinationSum2(int[] candidates, int target)
        {
            Array.Sort(candidates);
            Bt(candidates, target, 0, new List<int>());
            return result;
        }
        int prev = int.MinValue;
        private void Bt(int[] candidates, int target, int candidateStartIndex, List<int> steps)
        {
            if (target == 0)
            {
                result.Add(new List<int>(steps));
                return;
            }

           
            for (int i = candidateStartIndex; i < candidates.Length; i++)
            {
                if (candidates[i] <= target && candidates[i] != prev)
                {
                    steps.Add(candidates[i]);
                    Bt(candidates, target - candidates[i], i + 1, steps);
                    steps.RemoveAt(steps.Count - 1);
                    prev = candidates[i];
                    candidateStartIndex++;
                }
            }
        }


        public void Execute()
        {
            CombinationSum2(new int[] { 4, 4, 2, 1, 4, 2, 2, 1, 3 }, 6);
        }
    }
}