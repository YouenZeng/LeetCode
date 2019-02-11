using System.Collections.Generic;
using System.Text;

namespace LeetCode.LeetAgain
{
    internal class SlidingPuzzleSln : ISolution
    {
        public int SlidingPuzzle(int[,] board)
        {
            string final = "123450";
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < board.GetLength(0); i++)
            {
                for (int j = 0; j < board.GetLength(1); j++)
                {
                    sb.Append(board[i,j]);
                }
            }

            int[][] canMove = new int[][] {
                new int[]{1,3 },
                new int[]{0,2,4 },
                new int[]{ 1,5},
                new int[]{ 0,4},
                new int[]{1,3,5},
                new int[]{ 2,4}
            };

            HashSet<string> pathHash = new HashSet<string>();
            Queue<string> visitQueue = new Queue<string>();
            visitQueue.Enqueue(sb.ToString());

            pathHash.Add(sb.ToString());

            int result = 0;
            while (visitQueue.Count > 0)
            {
                int currentLayerCount = visitQueue.Count;
                for (int i = 0; i < currentLayerCount; i++)
                {
                    string q = visitQueue.Dequeue();
                    if (q == final)
                        return result;

                    int emptyTile = q.IndexOf('0');
                    foreach (int item in canMove[emptyTile])
                    {
                        string nextStep = Swap(q, emptyTile, item);
                        if (pathHash.Contains(nextStep))
                        {
                            continue;
                        }

                        visitQueue.Enqueue(nextStep);
                        pathHash.Add(nextStep);
                    }
                }
                result++;
            }
            return -1;
        }

        private string Swap(string input, int from, int to)
        {
            StringBuilder sb = new StringBuilder(input);
            sb[from] = input[to];
            sb[to] = input[from];
            return sb.ToString();
        }

        public void Execute()
        {
            System.Console.WriteLine(SlidingPuzzle(new int[,] { { 1, 2, 3 }, { 4, 5, 0 } }));
            System.Console.WriteLine(SlidingPuzzle(new int[,] { { 4, 1,2 }, { 5, 0, 3 } }));
            System.Console.WriteLine(SlidingPuzzle(new int[,] { { 1, 2, 3 }, { 5, 4, 0 } }));

        }
    }
}
