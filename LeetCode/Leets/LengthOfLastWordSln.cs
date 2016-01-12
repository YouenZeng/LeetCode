using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Leets
{
    public class LengthOfLastWordSln : ISolution
    {
        public int LengthOfLastWord(string s)
        {
            if (string.IsNullOrEmpty(s))
                return 0;
            var arr = s.Split(' ');
            for (int i = arr.Length - 1; i >= 0; i--)
            {
                if (string.IsNullOrEmpty(arr[i]) == false)
                {
                    return arr[i].Length;
                }
            }
            return 0;
        }
        public void Execute()
        {
           var result = LengthOfLastWord("  a ");
            Console.WriteLine(result);
        }
    }
}
