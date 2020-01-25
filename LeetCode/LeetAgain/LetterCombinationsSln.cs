using System.Collections.Generic;

namespace LeetCode.LeetAgain
{
    class LetterCombinationsSln : ISolution
    {
        public IList<string> LetterCombinations(string digits)
        {
            Dictionary<char, string> dict = new Dictionary<char, string>()
            {
                {'2', "abc"},
                {'3', "def"},
                {'4', "ghi"},
                {'5', "jkl"},
                {'6', "mno"},
                {'7', "pqrs"},
                {'8', "tuv"},
                {'9', "wxyz"}
            };

            var source = new List<string>();
            foreach (char c in digits)
            {
                source.Add(dict[c]);
            }

            var result = new List<string>();
            if (string.IsNullOrEmpty(digits))
                return result;
            List<char> lst = new List<char>();
            Dfs(source, 0, 0, result, lst);

            return result;
        }

        private void Dfs(List<string> source, int rowIndex, int colIndex, List<string> result, List<char> lst)
        {
            if (rowIndex == source.Count)
            {
                result.Add(string.Join("", lst));
                return;
            }

            for (int i = colIndex; i < source[rowIndex].Length; i++)
            {
                lst.Add(source[rowIndex][i]);
                Dfs(source, rowIndex + 1, 0, result, lst);
                lst.RemoveAt(lst.Count - 1);
            }
        }

        public void Execute()
        {
            LetterCombinations("");
        }
    }
}