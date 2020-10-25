using System;

namespace LeetCode.LeetAgain
{
    public class CalculateMinimumHPSln : ISolution
    {
        public int CalculateMinimumHP(int[][] dungeon)
        {
            int height = dungeon.GetLength(0);
            int width = dungeon[0].Length;

            int[][] minHpRequired = new int[width + 1][];
            int[][] maxHpLeft = new int[width + 1][];

            for (int i = 0; i <= width; i++)
            {
                minHpRequired[i] = new int[height + 1];
                maxHpLeft[i] = new int[height + 1];
            }

            for (int i = 0; i < width; i++)
            {
                for (int j = 0; j < height; j++)
                {
                    int leftMinHp = j == 0 ? 0 : minHpRequired[i][j - 1];
                    int upMinHp = i == 0 ? int.MaxValue : minHpRequired[i - 1][j];

                    int leftMaxHpRemaining = j == 0 ? 0 : maxHpLeft[i][j - 1];
                    int upMaxHpRemaining = j == 0 ? 0 : maxHpLeft[i][j - 1];

                    var cost = dungeon[i][j];

                    int leftGap = cost + leftMaxHpRemaining > 0 ? 0 : 1 + (cost + leftMaxHpRemaining) * -1;
                    int upGap = cost + upMaxHpRemaining > 0 ? 0 : 1 + (cost + upMaxHpRemaining) * -1;

                    minHpRequired[i][j] = Math.Min(leftMinHp + leftGap, upMinHp + upGap);
                    maxHpLeft[i][j] = Math.Max(leftGap > 0 ? 1 : (cost + leftMaxHpRemaining),
                        upGap > 0 ? 1 : (cost + upMaxHpRemaining));
                }
            }

            return minHpRequired[width][height];
        }

        public void Execute()
        {
            var arr = new int[3][];
            arr[0] = new[] {-2, -3, 3};
            arr[1] = new[] {-6, -10, 1};
            arr[2] = new[] {10, 30, -5};

            CalculateMinimumHP(arr);
        }
    }
}