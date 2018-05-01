using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.LeetAgain
{
    class ToGoatLatinSln : ISolution
    {
        public string ToGoatLatin(string S)
        {
            string[] arr = S.Split(' ');
            HashSet<char> hs = new HashSet<char>(new[]
            {
                'a', 'e', 'i', 'o', 'u', 'A', 'E', 'I', 'O', 'U'
            });
            string[] resultArray = new string[arr.Length];
            for (int i = 0; i < arr.Length; i++)
            {
                string current = arr[i];
                if (hs.Contains(current[0]))
                {
                    current = current + "ma";
                }
                else
                {
                    current = current.Substring(1, current.Length - 1) + current[0] + "ma";
                }

                for (int j = 0; j <= i; j++)
                {
                    current += 'a';
                }

                resultArray[i] = current;
            }

            return string.Join(" ", resultArray);
        }

        public void Execute()
        {
            throw new NotImplementedException();
        }
    }
}