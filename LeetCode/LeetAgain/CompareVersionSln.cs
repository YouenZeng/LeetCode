using System;
using LeetCode.Leets;

namespace LeetCode.LeetAgain
{
    public class CompareVersionSln : ISolution
    {
        public int CompareVersion(string version1, string version2)
        {
            //submit result
            //https://leetcode.com/submissions/detail/92631255/

            string[] v1Arr = version1.Split('.');
            string[] v2Arr = version2.Split('.');

            int itemCount = Math.Min(v1Arr.Length, v2Arr.Length);

            for (int i = 0; i < itemCount; i++)
            {
                if (Convert.ToInt32(v1Arr[i]) > Convert.ToInt32(v2Arr[i]))
                {
                    return 1;
                }

                if (Convert.ToInt32(v1Arr[i]) < Convert.ToInt32(v2Arr[i]))
                {
                    return -1;
                }
            }

            if (v1Arr.Length > itemCount)
            {
                for (int i = itemCount; i < v1Arr.Length; i++)
                {
                    if (Convert.ToInt32(v1Arr[i]) != 0)
                    {
                        return 1;
                    }
                }
            }

            if (v2Arr.Length > itemCount)
            {
                for (int i = itemCount; i < v2Arr.Length; i++)
                {
                    if (Convert.ToInt32(v2Arr[i]) != 0)
                    {
                        return -1;
                    }
                }
            }
            return 0;
        }
        void ISolution.Execute()
        {
            System.Console.WriteLine(CompareVersion("0.1","0.1"));
            System.Console.WriteLine(CompareVersion("0.1.01.0","0.1"));
            System.Console.WriteLine(CompareVersion("12.12","12.1.2"));
        }
    }
}