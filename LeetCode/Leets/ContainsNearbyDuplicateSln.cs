using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Leets
{
    public class ContainsNearbyDuplicateSln : ISolution
    {

        public bool ContainsNearbyDuplicate(int[] nums, int k)
        {
            var dict = new Dictionary<int, int>();
            for (int i = 0; i < nums.Length; i++)
            {
                if (dict.ContainsKey(nums[i]) == false)
                {
                    dict.Add(nums[i], i);
                    continue;
                }
                var pre = dict[nums[i]];
                if ((i - pre) <= k)
                {
                    return true;
                }

                //
                dict.Remove(nums[i]);
                dict.Add(nums[i], i);
            }
            return false;
        }
        public void Execute()
        {
            int[] arr = { 1,0,1,1 };
            Console.WriteLine(ContainsNearbyDuplicate(arr, 1));
        }
    }
}
