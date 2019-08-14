using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.LeetAgain
{

    /*
    procedure bt(c)
    if reject(P, c) then return
    if accept(P, c) then output(P, c)
    s ← first(P, c)
    while s ≠ NULL do
       bt(s)
       s ← next(P, s)
     */


    class SolveNQueensIIISln : ISolution
    {
        public IList<IList<string>> SolveNQueens(int n)
        {
            throw new NotImplementedException();
        }

        private void Bt(int rowIndex, int[,] current)
        {
            if (rowIndex >= current.GetLength(0))
            {
                PrintQueen();
            }

            for (int i = 0; i < current.GetLength(0); i++)
            {
                if (IsQueenValid(current, rowIndex, i))
                {
                    current[rowIndex, i] = 1;
                    Bt(rowIndex + 1, current);
                    current[rowIndex, i] = 0;
                }
            }
        }

        private bool IsQueenValid(int[,] current, int rowIndex, int colIndex)
        {
            throw new NotImplementedException();
        }

        private string PrintQueen()
        {
            throw new NotImplementedException();
        }

        public void Execute()
        {
            throw new NotImplementedException();
        }
    }
}
