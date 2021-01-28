using System;
using System.Collections.Generic;
using LeetCode.Leets;

namespace LeetCode.LeetAgain
{
    class DistributeCoinsSln : ISolution
    {
        int ans;
        public int DistributeCoins(TreeNode root)
        {
            //DFS
            ans = 0;
            dfs(root);
            return ans;

        }

        public int dfs(TreeNode node)
        {
            if (node == null) return 0;
            int L = dfs(node.left);
            int R = dfs(node.right);
            ans += Math.Abs(L) + Math.Abs(R);
            return node.val + L + R - 1;
        }

        public void Execute()
        {
            Console.WriteLine(DistributeCoins(TreeNode.FromArray(new int?[] {3, 0, 0})));
            Console.WriteLine(DistributeCoins(TreeNode.FromArray(new int?[] {0, 3, 0})));
            Console.WriteLine(DistributeCoins(TreeNode.FromArray(new int?[] {1, 0, 2})));
            Console.WriteLine(DistributeCoins(TreeNode.FromArray(new int?[] {1, 0, 0, null, 3, null, null})));
        }
    }
}