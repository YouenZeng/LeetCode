using System;

namespace LeetCode.LeetAgain
{
    class WordSearchSln : ISolution
    {
        private int _boardWidth;
        private int _boardHeight;
        private int _wordLength;

        public bool Exist(char[,] board, string word)
        {
            _wordLength = word.Length;
            _boardWidth = board.GetLength(1);
            _boardHeight = board.GetLength(0);

            bool[,] historyBoard = new bool[_boardHeight, _boardWidth];

            for (int i = 0; i < _boardHeight; i++)
            {
                for (int j = 0; j < _boardWidth; j++)
                {
                    if (board[i, j] == word[0] && Exist(board, historyBoard, word, i, j, 0))
                    {
                        return true;
                    }
                }
            }

            return false;
        }

        private bool Exist(char[,] board, bool[,] historyBoard, string word, int x, int y, int wordStartIndex)
        {
            if (wordStartIndex >= _wordLength)
            {
                return true;
            }

            if (x < 0 || y < 0) return false;
            if (x >= _boardHeight || y >= _boardWidth) return false;
            if (word[wordStartIndex] != board[x, y]) return false;
            if (historyBoard[x, y]) return false;

            historyBoard[x, y] = true;

            if (Exist(board, historyBoard, word, x - 1, y, wordStartIndex + 1) ||
                Exist(board, historyBoard, word, x + 1, y, wordStartIndex + 1) ||
                Exist(board, historyBoard, word, x, y - 1, wordStartIndex + 1) ||
                Exist(board, historyBoard, word, x, y + 1, wordStartIndex + 1))
                return true;

            historyBoard[x, y] = false;
            return false;
        }

        public void Execute()
        {
            char[,] board =
            {
                {'A', 'B', 'C', 'E'},
                {'S', 'F', 'C', 'S'},
                {'A', 'D', 'E', 'E'}
            };
            //  Exist(board, "AB");
            Console.WriteLine(Exist(board, "ABCESEEDASFC"));
        }
    }
}