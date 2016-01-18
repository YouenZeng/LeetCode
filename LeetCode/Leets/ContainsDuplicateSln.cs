using System;
using System.Collections.Generic;

namespace LeetCode.Leets
{
    public class ContainsDuplicateSln : ISolution
    {
        public bool ContainsDuplicate(int[] nums)
        {
            return new HashSet<int>(nums).Count != nums.Length;
        }
        public void Execute()
        {
            int[] arr = { 0 };

            Console.WriteLine(ContainsDuplicate(arr));
        }
    }
}
