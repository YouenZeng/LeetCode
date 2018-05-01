using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode.LeetAgain
{
    class ReverseWordsIIISln : ISolution
    {
        public string ReverseWords(string s)
        {
            string[] arr = s.Split(' ');

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = string.Join("", arr[i].Reverse());
            }

            return string.Join(' ', arr);
        }

        public void Execute()
        {
            throw new NotImplementedException();
        }
    }
}