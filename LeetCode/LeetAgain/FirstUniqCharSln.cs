using System;
using System.Collections.Generic;

namespace LeetCode.LeetAgain
{
    public class FirstUniqCharSln : ISolution
    {
        public int FirstUniqChar(string s)
        {
            int[] arr = new int[256];

            for (int i = 0; i < s.Length; i++)
            {
                arr[(int)s[i]]++;
            }
            for (int i = 0; i < s.Length; i++)
            {
                if (arr[(int)s[i]] == 1)
                    return i;
            }
            return -1;

        }
        void ISolution.Execute()
        {
            throw new NotImplementedException();
        }
    }
}