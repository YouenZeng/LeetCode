using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Leets
{
    class IsValidSudokuSln : ISolution
    {
        public bool IsValidSudoku(char[,] board)
        {
            int boardWidth = board.GetLength(0);
            int boardHeight = board.GetLength(1);

            if (boardHeight != 9 || boardWidth != 9) return false;

            for (int i = 0; i < boardWidth; i++)
            {
                if (CheckValid(board, i, -1) == false) return false;
                if (CheckValid(board, -1, i) == false) return false;
            }

            for (int i = 3; i <= 9; i += 3)
            {
                for (int j = 3; j <= 9; j += 3)
                {
                    if (CheckValid(board, i, j) == false) return false;
                }
            }

            return true;
        }

        public bool CheckValid(char[,] input, int i, int j)
        {
            HashSet<int> hs = new HashSet<int>();
            int numsCount = 0;
            //纵向
            if (j < 0)
            {
                for (int k = 0; k < 9; k++)
                {
                    if (input[i, k] == '.') continue;
                    hs.Add(Convert.ToInt32(input[i, k]));
                    numsCount++;
                }
            }
            //横向
            else if (i < 0)
            {
                for (int k = 0; k < 9; k++)
                {
                    if (input[k,j] == '.') continue;
                    hs.Add(Convert.ToInt32(input[ k,j]));
                    numsCount++;
                }
            }
            else
            {
                for (int k = i - 3; k < i; k++)
                {
                    for (int l = j - 3; l < j; l++)
                    {
                        if (input[k,l] == '.') continue;
                        hs.Add(Convert.ToInt32(input[k,l]));
                        numsCount++;
                    }
                }
            }

            if (hs.Count != numsCount) return false;
            return true;


        }
        public void Execute()
        {
            throw new NotImplementedException();
        }
    }
}
