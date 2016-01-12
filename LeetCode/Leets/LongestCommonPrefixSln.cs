using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Leets
{
    /// <summary>
    /// Write a function to find the longest common prefix string amongst an array of strings.
    /// </summary>
    public class LongestCommonPrefixSln : ISolution
    {
        public string LongestCommonPrefix(string[] strs)
        {
            if (strs == null || strs.Length == 0)
                return string.Empty;

            string pre = strs[0];
            int i = 1;
            while (i < strs.Length)
            {
                while (strs[i].IndexOf(pre, StringComparison.Ordinal) != 0)
                {
                    pre = pre.Substring(0, pre.Length - 1);
                }
                i++;
            }
            return pre;
        }
        public void Execute()
        {
            string[] arr = { "abcdefgaaaaaaaaaaaa", "abcde" };
            LongestCommonPrefix(arr);
        }
    }
}
