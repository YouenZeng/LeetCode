using System;
using System.Collections.Generic;

namespace LeetCode.LeetAgain
{
    class SolveNQueensSln : ISolution
    {
        IList<IList<string>> finalResult = new List<IList<string>>();
        public IList<IList<string>> SolveNQueens(int n)
        {
            //plain solution

            int[,] queen = new int[n, n];

            NQueenInternal(queen, 0);
            return finalResult;
        }

        private void NQueenInternal(int[,] queen, int row)
        {
            if (row >= queen.GetLength(0))
            {
                var s = DrawQueen(queen);
                finalResult.Add(s);
            }

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

        private bool CanPlaceQueen(int[,] queen, int x, int y)
        {
            for (int i = 0; i < x; i++)
            {
                if (queen[i, y] == 1) return false;
            }


            for (int i = x, j = y; i >= 0 && j >= 0; i--, j--)
            {
                if (queen[i, j] == 1) return false;
            }

            for (int i = x, j = y; i >= 0 && j < queen.GetLength(0); i--, j++)
            {
                if (queen[i, j] == 1) return false;
            }


            return true;
        }

        private IList<string> DrawQueen(int[,] queen)
        {
            IList<string> result = new List<string>();
            for (int i = 0; i < queen.GetLength(0); i++)
            {
                string s = String.Empty;
                for (int j = 0; j < queen.GetLength(0); j++)
                {
                    if (queen[i, j] == 1)
                    {
                        s += "Q";
                    }
                    else
                    {
                        s += ".";
                    }
                }

                result.Add(s);
            }

            return result;
        }
        public void Execute()
        {
            Console.WriteLine(SolveNQueens(4));
        }
    }
}
