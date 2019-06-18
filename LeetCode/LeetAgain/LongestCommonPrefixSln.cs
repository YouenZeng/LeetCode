using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.LeetAgain
{
    class LongestCommonPrefixSln : ISolution
    {
        public string LongestCommonPrefix(string[] strs)
        {
            List<string> result = new List<string>();

            if (strs.Length == 0) return string.Empty;  

            int count = 0;
            while (true)
            {
                if (strs[0].Length <= count)
                {
                    return string.Join("", result);
                }
                char fist = strs[0][count];
                for (int i = 1; i < strs.Length; i++)
                {
                    if (strs[i].Length <= count)
                    {
                        return string.Join("", result);
                    }
                    if (strs[i][count] != fist)
                    {
                        return string.Join("", result);
                    }
                }
                result.Add(fist.ToString());
                count++;
            }
        }
        public void Execute()
        {
            LongestCommonPrefix(new[] { "flavor", "flower", "floor" });
            LongestCommonPrefix(new[] { "a", "e", "f" });
            LongestCommonPrefix(new[] { "flower", "flow", "flight" });
        }
    }
}