using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Leets
{
    class SummaryRangesSln : ISolution
    {
        public IList<string> SummaryRanges(int[] nums)
        {
            IList<string> result = new List<string>();
            int current = 0;
            while (current < nums.Length)
            {
                int begin = nums[current];
                int beginCached = nums[current];
                string endString = String.Empty;

                while (current < nums.Length && begin == nums[current])
                {
                    begin++;
                    current++;
                }
                if (beginCached < (begin-1))
                {
                    endString = "->" + --begin;
                }

                result.Add(beginCached + endString);
            }

            return result;
        }
        public void Execute()
        {
            int[] nums = {  };
            SummaryRanges(nums);
        }
    }
}
