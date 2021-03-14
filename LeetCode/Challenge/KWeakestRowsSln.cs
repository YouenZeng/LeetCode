using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using LeetCode.Leets;

namespace LeetCode.Challenge
{
    class KWeakestRowsSln : ISolution
    {
        public int[] KWeakestRows(int[][] mat, int k)
        {
            int width = mat[0].Length;
            int height = mat.GetLength(0);
            Tuple<int, int>[] arr = new Tuple<int, int>[height];

            for (int i = 0; i < height; i++)
            {
                int soldierCount = 0;
                for (int j = 0; j < width; j++)
                {
                    if (mat[i][j] == 1)
                    {
                        soldierCount++;
                    }
                }

                arr[i] = new Tuple<int, int>(i, soldierCount);
            }

            int[] newArray = arr.OrderBy(a => a.Item2).ThenBy(b => b.Item1).Select(c => c.Item1).ToArray();

            int[] result = new int[k];
            Array.Copy(newArray, result, k);
            return result;
        }

        public bool FlipEquiv(TreeNode root1, TreeNode root2)
        {
            if (root1 == root2)
                return true;
            if (root1 == null || root2 == null || root1.val != root2.val)
                return false;

            return ((FlipEquiv(root1.left, root2.left) && FlipEquiv(root1.right, root2.right)) ||
                    (FlipEquiv(root1.left, root2.right) && FlipEquiv(root1.right, root2.left)));
        }

        public void Execute()
        {
            int[][] mat =
            {
                new[] {1, 1, 0, 0, 0}, new[] {1, 1, 1, 1, 0}, new[] {1, 0, 0, 0, 0},
                new[] {1, 1, 0, 0, 0}, new[] {1, 1, 1, 1, 1}
            };
            KWeakestRows(mat, 3);
        }
    }
}