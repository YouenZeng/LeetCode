using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.LeetAgain
{
    class TotalNQueensSln : ISolution
    {

        int totalCount = 0;
        public int TotalNQueens(int n)
        {
            int[,] queen = new int[n, n];
            NQueenInternal(queen, 0);
            return totalCount;
        }


        private void NQueenInternal(int[,] queen, int row)
        {
            if (row >= queen.GetLength(0))
            {
                totalCount++;
            }

            //backtrack/DFS
            for (int i = 0; i < queen.GetLength(0); i++)
            {
                if (CanPlaceQueen(queen, row, i))
                {
                    queen[row, i] = 1;

                    NQueenInternal(queen, row + 1);

                    queen[row, i] = 0;
                }
            }
        }

        //按行遍历
        private bool CanPlaceQueen(int[,] queen, int x, int y)
        {
            //列, 查看Y列能否放置
            for (int i = 0; i < x; i++)
            {
                if (queen[i, y] == 1) return false;
            }

            //斜线, 往左上方向
            for (int i = x, j = y; i >= 0 && j >= 0; i--, j--)
            {
                if (queen[i, j] == 1) return false;
            }

            //斜线, 往右下方向
            for (int i = x, j = y; i >= 0 && j < queen.GetLength(0); i--, j++)
            {
                if (queen[i, j] == 1) return false;
            }


            return true;
        }


        public void Execute()
        {
            TotalNQueens(10);
        }
    }
}
