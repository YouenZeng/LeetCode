using System;
using System.Text;

namespace LeetCode.LeetAgain
{
    public class ReverseWordsSln : ISolution
    {
        public string ReverseWords(string s)
        {
            if (string.IsNullOrEmpty(s))
                return s;
            string[] arr = s.Trim().Split(new[] { " " }, StringSplitOptions.None);
            int arrLength = arr.Length;
            if (arrLength == 1)
                return arr[0];
            var sb = new StringBuilder();

            for (int i = arrLength - 1; i >= 0; i--)
            {
                if (string.IsNullOrEmpty(arr[i]))
                    continue;
                sb.Append(arr[i]);
                sb.Append(" ");
            }

            if (sb.Length == 0)
                return string.Empty;

            return sb.ToString().Substring(0, sb.Length - 1);
        }
        void ISolution.Execute()
        {
            System.Console.WriteLine(ReverseWords("   a   b ")); ;
        }
    }
}