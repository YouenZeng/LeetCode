using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.LeetAgain
{
    class ReverseStringSln : ISolution
    {
        public string ReverseString(string s)
        {
            if (s.Length <= 1) return s;

            StringBuilder sb = new StringBuilder();
            for (int i = s.Length - 1; i > 0; i--)
            {
                sb.Append(s[i]);
            }
            return sb.ToString();
        }
        public string ReverseStringV2(string s)
        {
            if (s.Length <= 1) return s;

            char[] arr = s.ToCharArray();
            int start = 0;
            int end = arr.Length - 1;
            while (start <= end)
            {
                char t = arr[end];
                arr[end] = arr[start];
                arr[start] = t;
                start++;
                end--;
            }
            return new string(arr);
        }
        public void Execute()
        {
            throw new NotImplementedException();
        }
    }
}
