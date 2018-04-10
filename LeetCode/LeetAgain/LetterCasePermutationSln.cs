using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.LeetAgain
{
    class LetterCasePermutationSln : ISolution
    {
        private IList<string> resultList = new List<string>();

        public IList<string> LetterCasePermutation(string S)
        {
            char[] result = new char[S.Length];

            LetterCaseInternal(S, result, 0);
            return resultList;
        }

        private void LetterCaseInternal(string s, char[] result, int currentIndex)
        {
            if (currentIndex >= s.Length)
            {
                resultList.Add(string.Join("", result));
                return;
            }

            result[currentIndex] = s[currentIndex];
            LetterCaseInternal(s, result, currentIndex + 1);

            if (char.IsLetter(s[currentIndex]))
            {
                result[currentIndex] =
                    s[currentIndex] > 90 ? (char) (s[currentIndex] - 32) : (char) (s[currentIndex] + 32);
                LetterCaseInternal(s, result, currentIndex + 1);
            }
        }


        public void Execute()
        {
            LetterCasePermutation("1aB23");
        }
    }
}