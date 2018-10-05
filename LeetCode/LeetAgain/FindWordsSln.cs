using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode.LeetAgain
{
    class FindWordsSln : ISolution
    {
        public IList<string> FindWords(char[,] board, string[] words)
        {
            HashSet<string> hs = new HashSet<string>();
            foreach (string word in words)
            {
                if (WordCheck(board, word))
                {
                    hs.Add(word);
                }
            }

            return hs.ToList();
        }

        private bool WordCheck(char[,] board, string word)
        {
            bool[,] visited = new bool[board.GetLength(0), board.GetLength(1)];

            for (int i = 0; i < board.GetLength(0); i++)
            {
                for (int j = 0; j < board.GetLength(1); j++)
                {
                    if (WordCheckInternal(board, word, 0, i, j, visited))
                    {
                        return true;
                    }
                }
            }
            return false;

        }

        private bool WordCheckInternal(char[,] board, string word, int stringIndex, int boardX, int boardY, bool[,] visisted)
        {
            if (boardX < 0 || boardX >= board.GetLength(0)) return false;
            if (boardY < 0 || boardY >= board.GetLength(1)) return false;
            if (visisted[boardX, boardY]) return false;

            if (visisted[boardX, boardY] == false && board[boardX, boardY] == word[stringIndex])
            {
                if (stringIndex == word.Length - 1)
                {
                    return true;
                }
                visisted[boardX, boardY] = true;
                if (WordCheckInternal(board, word, stringIndex + 1, boardX - 1, boardY, visisted) ||
                 WordCheckInternal(board, word, stringIndex + 1, boardX + 1, boardY, visisted) ||
                 WordCheckInternal(board, word, stringIndex + 1, boardX, boardY - 1, visisted) ||
                 WordCheckInternal(board, word, stringIndex + 1, boardX, boardY + 1, visisted)
                 )
                {
                    return true;
                }
                visisted[boardX, boardY] = false;
                return false;
            }
            else
            {
                return false;
            }
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
