using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Challenge
{
    class GameOfLifeSln : ISolution
    {
        public void GameOfLife(int[][] board)
        {
            int width = board[0].Length;
            int height = board.GetLength(0);
            int[][] boardCopy = new int[height][];

            for (int i = 0; i < height; i++)
            {
                boardCopy[i] = new int[width];
                for (int j = 0; j < width; j++)
                {
                    boardCopy[i][j] = board[i][j];

                    int neighborOneCount = CountBoard(1, board, width, height, i, j);

                    if (board[i][j] == 0)
                    {
                        if (neighborOneCount == 3)
                        {
                            boardCopy[i][j] = 1;
                        }
                    }

                    if (board[i][j] == 1)
                    {
                        if (neighborOneCount < 2 || neighborOneCount > 3)
                        {
                            boardCopy[i][j] = 0;
                        }
                    }
                }
            }

            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    board[i][j] = boardCopy[i][j];
                }
            }
        }

        private int CountBoard(int count, int[][] board, int width, int height, int x, int y)
        {
            int result = 0;
            for (int i = x - 1; i <= x + 1; i++)
            {
                for (int j = y - 1; j <= y + 1; j++)
                {
                    if (i < 0 || i >= height || j < 0 || j >= width || (i == x && j == y))
                    {
                        continue;
                    }

                    result += board[i][j] == count ? 1 : 0;
                }
            }

            return result;
        }


        public void Execute()
        {
            GameOfLife(new int[4][]
            {
                new int[3] {0, 1, 0},
                new int[3] {0, 0, 1},
                new int[3] {1, 1, 1},
                new int[3] {0, 0, 0},
            });

            GameOfLife(new int[][]
            {
                new int[] {1},
                new int[] {0},
                new int[] {0},
                new int[] {1},
                new int[] {0},
                new int[] {0},
                new int[] {1},
                new int[] {0},
                new int[] {0},
                new int[] {1},
            });
        }
    }
}