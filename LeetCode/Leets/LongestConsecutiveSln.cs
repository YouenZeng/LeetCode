using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Leets
{
  public  class LongestConsecutiveSln:ISolution
    {
      public int LongestConsecutive(int[] nums)
      {
          if (nums == null || nums.Length == 0)
              return 0;

          int longest = 1;
          Dictionary<int,int> maps = new Dictionary<int, int>();
          
          for (int i = 0; i < nums.Length; i++)
          {
              if (maps.ContainsKey(nums[i]) == false) maps.Add(nums[i], nums[i] + 1);
          }
          for (int i = 0; i < nums.Length; i++)
          {
              int current = 1;
              int key = nums[i];
              //非最小的,跳过
              if (maps.ContainsKey(key-1))
                  continue;

              while (maps.ContainsKey(maps[key]))
              {
                  current++;
                  key = maps[key];
              }
              if (current > longest)
                  longest = current;
          }
          return longest;
      }



      public void Execute()
      {
          throw new NotImplementedException();
      }
    }
}
