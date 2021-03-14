using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Challenge
{
    class LetterCasePermutationSln : ISolution
    {
        public IList<string> LetterCasePermutation(string S)
        {
            char[] arr = S.ToCharArray();
            IList<string> result = new List<string>();
            Dfs(arr, 0, result);

            return result;
        }

        private void Dfs(char[] arr, int i, IList<string> result)
        {
            if (i == arr.Length)
            {
                result.Add(new string(arr));
                return;
            }

            if (!char.IsLetter(arr[i]))
            {
                Dfs(arr, i + 1, result);
            }
            else
            {
                Dfs(arr, i + 1, result);
                arr[i] = (char) (arr[i] + 0x20 * (arr[i] >= 'a' ? -1 : 1));
                Dfs(arr, i + 1, result);
            }
        }

        public void Execute()
        {
            LetterCasePermutation("C");
        }
    }
}