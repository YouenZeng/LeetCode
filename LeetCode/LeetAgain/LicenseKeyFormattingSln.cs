using System;
using System.Text;
using Leetcode;

namespace LeetCode.LeetAgain
{
   public class LicenseKeyFormattingSln : ISolution
    {
        public string LicenseKeyFormatting(string S, int K)
        {
            S = S.Replace("-", "");

            if (S.Length <= K)
                return S.ToUpper();
            StringBuilder sb = new StringBuilder();
            int firstGroupLength = S.Length % K;
            int groupCount = S.Length / K;

            int currentStringIndex = 0;

            if (firstGroupLength != 0)
            {
                sb.Append(S.Substring(0, firstGroupLength).ToUpper());
                sb.Append("-");
                currentStringIndex = firstGroupLength;
            }

            for (int i = 0; i < groupCount; i++)
            {
                sb.Append(S.Substring(currentStringIndex, K).ToUpper());
                sb.Append("-");
                currentStringIndex += K;
            }

            return sb.ToString().Substring(0, sb.Length - 1);
        }

        void ISolution.Execute()
        {
            System.Console.WriteLine(LicenseKeyFormatting("r", 4));
        }
    }
}