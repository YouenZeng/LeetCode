using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.LeetAgain
{
    class IsValidSudokuSln : ISolution
    {
        public bool IsValidSudoku(char[][] board)
        {
            List<HashSet<char>> hsList = new List<HashSet<char>>();

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


                    if (!hsList[i].Add(board[i][j]))
                    {
                        return false;
                    }

                    if (!hsList[9 + j].Add(board[i][j]))
                    {
                        return false;
                    }

                    if (!hsList[18 + j / 3 + (i / 3) * 3].Add(board[i][j]))
                    {
                        return false;
                    }
                }
            }

            return true;
        }

        public void Execute()
        {
            IsValidSudoku(new char[][]
            {
                new char[] {'5', '3', '.', '.', '7', '.', '.', '.', '.'},
                new char[] {'6', '.', '.', '1', '9', '5', '.', '.', '.'},
                new char[] {'.', '9', '8', '.', '.', '.', '.', '6', '.'},
                new char[] {'8', '.', '.', '.', '6', '.', '.', '.', '3'},
                new char[] {'4', '.', '.', '8', '.', '3', '.', '.', '1'},
                new char[] {'7', '.', '.', '.', '2', '.', '.', '.', '6'},
                new char[] {'.', '6', '.', '.', '.', '.', '2', '8', '.'},
                new char[] {'.', '.', '.', '4', '1', '9', '.', '.', '5'},
                new char[] {'.', '.', '.', '.', '8', '.', '.', '7', '9'}
            });
        }
    }
}