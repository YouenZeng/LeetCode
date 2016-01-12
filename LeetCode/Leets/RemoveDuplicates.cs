using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Leets
{
   public class RemoveDuplicates:ISolution
    {
       public int RemoveDuplicatesMethod(int[] nums)
       {
           if (nums.Length == 0)
               return 0;
           int count = 1;
           int flag = 1;
           for (int i = 1; i < nums.Length; i++)
           {
               if (nums[i] == nums[i - 1])
               {
                   continue;
               }
               nums[flag++] = nums[i];
               count++;
           }
           return count;
       }
       public void Execute()
       {
       //    var arr = new[] {1,1,2};
        var arr = new[] {1,1,2,2,3,4,5};
           var solution = new RemoveDuplicates();
           Console.WriteLine(solution.RemoveDuplicatesMethod(arr));
       }
    }
}
