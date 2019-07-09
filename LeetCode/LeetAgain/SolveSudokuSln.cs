using System;
using System.Collections.Generic;

namespace LeetCode.LeetAgain
{
    class SolveSudokuSln : ISolution
    {
        List<HashSet<char>> hsList = new List<HashSet<char>>();

        public void SolveSudoku(char[][] board)
        {
            for (int i = 0; i < 27; i++)
            {
                hsList.Add(new HashSet<char>());
            }

            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    if (board[i][j] == '.')
                        continue;

                    hsList[i].Add(board[i][j]);
                    hsList[9 + j].Add(board[i][j]);
                    hsList[18 + j / 3 + (i / 3) * 3].Add(board[i][j]);
                }
            }

            TrySolveSudo(board, 0);
        }

        private bool sudoSolved;

        private void TrySolveSudo(char[][] board, int bIndex)
        {
            if (sudoSolved)
            {
                return;
            }

            if (IsSudoCompleted(board, bIndex))
            {
                return;
            }

            int i = bIndex / 9;
            int j = bIndex % 9;

            if (board[i][j] != '.')
            {
                TrySolveSudo(board, bIndex + 1);
            }

            int currentX = 1;
            while (currentX < 10 && board[i][j] == '.')
            {
                char item = (char) (48 + currentX);


                if (!hsList[i].Contains(item) && !hsList[9 + j].Contains(item) &&
                    !hsList[18 + j / 3 + (i / 3) * 3].Contains(item))
                {
                    board[i][j] = item;

                    hsList[i].Add(item);
                    hsList[9 + j].Add(item);
                    hsList[18 + j / 3 + (i / 3) * 3].Add(item);

                    TrySolveSudo(board, bIndex + 1);
                    if (!sudoSolved)
                    {
                        board[i][j] = '.';
                        hsList[i].Remove(item);
                        hsList[9 + j].Remove(item);
                        hsList[18 + j / 3 + (i / 3) * 3].Remove(item);
                    }
                }

                currentX++;
            }
        }

        private bool IsSudoCompleted(char[][] board, int bIndex)
        {
            if (bIndex > 80)
            {
                sudoSolved = true;
                return true;
            }

            return false;
        }

        public void Execute()
        {
            var board = new char[][]
            {
                new char[] {'5', '3', '.', '.', '7', '.', '.', '.', '.'},
                new char[] {'6', '.', '.', '1', '9', '5', '.', '.', '.'},
                new char[] {'.', '9', '8', '.', '.', '.', '.', '6', '.'},
                new char[] {'8', '.', '.', '.', '6', '.', '.', '.', '3'},
                new char[] {'4', '.', '.', '8', '.', '3', '.', '.', '1'},
                new char[] {'7', '.', '.', '.', '2', '.', '.', '.', '6'},
                new char[] {'.', '6', '.', '.', '.', '.', '2', '8', '.'},
                new char[] {'.', '.', '.', '4', '1', '9', '.', '.', '5'},
                new char[] {'.', '.', '.', '.', '8', '.', '.', '7', '.'}
            };

            SolveSudoku(board);
        }
    }
}