using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.LeetAgain
{
    class CombinationSumSln : ISolution
    {
        //procedure bt(c)
        //    if reject(P, c) then return
        //if accept(P, c) then output(P, c)
        //s ← first(P, c)
        //    while s ≠ NULL do
        //bt(s)
        //s ← next(P, s)


        IList<IList<int>> result = new List<IList<int>>();

        public IList<IList<int>> CombinationSum(int[] candidates, int target)
        {
            Array.Sort(candidates);
            Bt(candidates, target, 0, new List<int>());
            return result;
        }

        private void Bt(int[] candidates, int target, int candidateStartIndex, List<int> steps)
        {
            if (target == 0)
            {
                ////we found it!
                //Console.WriteLine(string.Join("", steps));
                //Console.WriteLine(Environment.NewLine);

                result.Add(new List<int>(steps));
                return;
            }

            for (int i = candidateStartIndex; i < candidates.Length; i++)
            {
                if (candidates[i] <= target)
                {
                    steps.Add(candidates[i]);
                    Bt(candidates, target - candidates[i], candidateStartIndex, steps);
                    steps.RemoveAt(steps.Count - 1);
                    candidateStartIndex++;
                }
            }
        }

        public void Execute()
        {
            CombinationSum(new int[] {2, 3, 6, 7}, 7);
        }
    }
}