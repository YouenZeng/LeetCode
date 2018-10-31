using System;
using System.Collections.Generic;

namespace LeetCode.LeetAgain
{
    class FindWordsSln : ISolution
    {

        public List<string> FindWords(char[,] board, string[] words)
        {
            List<string> result = new List<string>();

            TrieNode root = BuildTrie(words);

            for (int i = 0; i < board.GetLength(0); i++)
            {
                for (int j = 0; j < board.GetLength(1); j++)
                {
                    Dfs(board, i, j, root, result);
                }
            }
            return result;
        }

        public void Dfs(char[,] board, int i, int j, TrieNode p, List<string> result)
        {
            char c = board[i, j];

            if (c == '#' || p.Next[c - 'a'] == null) return;

            p = p.Next[c - 'a'];
            if (p.Word != null)
            {
                result.Add(p.Word);
                p.Word = null;
            }

            board[i, j] = '#';

            if (i > 0) Dfs(board, i - 1, j, p, result);
            if (j > 0) Dfs(board, i, j - 1, p, result);
            if (i < board.GetLength(0) - 1) Dfs(board, i + 1, j, p, result);
            if (j < board.GetLength(1) - 1) Dfs(board, i, j + 1, p, result);

            board[i, j] = c;
        }

        public TrieNode BuildTrie(string[] words)
        {
            TrieNode trieNode = new TrieNode();
            foreach (var word in words)
            {
                TrieNode p = trieNode;

                foreach (char c in word)
                {
                    int i = c - 'a';
                    if (p.Next[i] == null) p.Next[i] = new TrieNode();
                    p = p.Next[i];
                }
                p.Word = word;
            }
            return trieNode;
        }
        public class TrieNode
        {
            public TrieNode()
            {
                Next = new TrieNode[26];
            }
            public TrieNode[] Next { get; set; }
            public string Word { get; set; }
        }
        public void Execute()
        {
            var r = FindWords(new char[4, 4] { { 'o', 'a', 'a', 'n' },
                { 'e', 't', 'a', 'e' },
                { 'i', 'h', 'k', 'r' },
                { 'i', 'f', 'l', 'v' } }, new string[] { "aklfhta", "eat" });
            Console.WriteLine(r);
        }
    }


}
