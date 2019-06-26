using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode.LeetAgain
{
    class LetterCombinationsBfsSln : ISolution
    {
        public IList<string> LetterCombinations(string digits)
        {
            List<string> result = new List<string>();
            if (string.IsNullOrEmpty(digits))
                return result;

            String[] mapping = new String[] { "0", "1", "abc", "def", "ghi", "jkl", "mno", "pqrs", "tuv", "wxyz" };
            result.Add("");

            for (int i = 0; i < digits.Length; i++)
            {
                int x = (int)Char.GetNumericValue(digits[i]);

                while (result.First().Length == i)
                {
                    string t = result.First();
                    result.RemoveAt(0);
                    foreach (char c in mapping[x].ToCharArray())
                    {
                        result.Add(t + c);
                    }
                }
            }

            return result;
        }

        public void Execute()
        {
            LetterCombinations("233");
        }
    }
}
