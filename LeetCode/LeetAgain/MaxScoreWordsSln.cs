using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.LeetAgain
{
    class MaxScoreWordsSln : ISolution
    {
        public int MaxScoreWords(string[] words, char[] letters, int[] score)
        {
            //DFS backtracking
            //1. describe words, letters
            //2. add visisted
            //3. DFS, if cannot go deeper, backtrack

            int[] letterDict = new int[26];
            Dictionary<int, int> scoreOfWords = new Dictionary<int, int>();

            for (int i = 0; i < words.Length; i++)
            {
                int s = 0;
                for (int j = 0; j < words[i].Length; j++)
                {
                    s += score[words[i][j] - 'a'];
                }
                scoreOfWords[i] = s;
            }

            for (int i = 0; i < letters.Length; i++)
            {
                letterDict[letters[i] - 'a']++;
            }
            var r = Math.Max(0, Dfs(words, letterDict, scoreOfWords, 0, 0));
            return r;
        }

        private int Dfs(string[] words, int[] letterDict, Dictionary<int, int> scoreOfWords, int startIndex, int max)
        {
            int tMax = max;

            for (int i = startIndex; i < words.Length; i++)
            {
                bool canContinue = true;
                foreach (var w in words[i])
                {
                    letterDict[w - 'a']--;
                    if (letterDict[w - 'a'] < 0)
                    {
                        canContinue = false;
                    }
                }

                if (canContinue)
                {
                    int score = Dfs(words, letterDict, scoreOfWords, 1 + i, max + scoreOfWords[i]);
                    tMax = Math.Max(tMax, score);
                }
                
                foreach (var w in words[i])
                {
                    letterDict[w - 'a']++;
                }
            }

            return tMax;
        }

        public void Execute()
        {
            MaxScoreWords(new string[] { "dog", "cat", "dad", "good" }, new char[] { 'a', 'a', 'c', 'd', 'd', 'd', 'g', 'o', 'o' }, new int[] { 1, 0, 9, 5, 0, 0, 3, 0, 0, 0, 0, 0, 0, 0, 2, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 });

            MaxScoreWords(new string[] { "xxxz", "ax", "bx", "cx" }, new char[] { 'z', 'a', 'b', 'c', 'x', 'x', 'x' }, new int[] { 4, 4, 4, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 5, 0, 10 });

            MaxScoreWords(new string[] { "add", "dda", "bb", "ba", "add" }, new char[] { 'a', 'a', 'a', 'a', 'b', 'b', 'b', 'b', 'c', 'c', 'c', 'c', 'c', 'd', 'd', 'd' }, new int[] { 3, 9, 8, 9, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 });
        }
    }
}
