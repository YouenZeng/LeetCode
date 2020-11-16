using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Lof
{
    class ReplaceSpaceSln : ISolution
    {
        public string ReplaceSpace(string s)
        {
            return s.Replace(" ", "%20");
        }

        public string ReplaceSpace2(string s)
        {
            int spaceCount = 0;
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == ' ')
                {
                    spaceCount++;
                }
            }
            char[] arr = new char[s.Length + spaceCount * 2];

            int newArrIndex = arr.Length - 1;
            for (int i = s.Length - 1; i >= 0; i--)
            {
                if (s[i] != ' ')
                {
                    arr[newArrIndex--] = s[i];
                }
                else
                {
                    arr[newArrIndex--] = '0';
                    arr[newArrIndex--] = '2';
                    arr[newArrIndex--] = '%';
                }
            }
            return new string(arr);

        }

        public void Execute()
        {
            ReplaceSpace2("you are shabi");
        }
    }
}
