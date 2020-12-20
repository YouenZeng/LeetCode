using System;
using System.Collections.Generic;
using System.Text;
using LeetCode.Leets;

namespace LeetCode.Challenge
{
    class HouseRobberIIISln : ISolution
    {
        Dictionary<TreeNode, int> dp = new Dictionary<TreeNode, int>();

        public int Rob(TreeNode root)
        {
            //return max(root.val + Rot(root.left.left)+Rob(root.left.right)  + Rob(root.right.left)+Rob(root.right.right),   Rob(root.left)+Rob(root.right))

            //DFS
            if (root == null)
            {
                return 0;
            }

            if (dp.ContainsKey(root))
            {
                return dp[root];
            }

            if (root.left == null && root.right == null)
            {
                dp[root] = root.val;
                return dp[root];
            }

            int leftNextLayer = 0;
            if (root.left != null)
            {
                leftNextLayer = Rob(root.left.left) + Rob(root.left.right);
            }

            int rightNextLayer = 0;
            if (root.right != null)
            {
                rightNextLayer = Rob(root.right.left) + Rob(root.right.right);
            }

            dp[root]= Math.Max(
                root.val + leftNextLayer + rightNextLayer,
                Rob(root.left) + Rob(root.right));
            return dp[root];
        }

        public void Execute()
        {
            TreeNode node = TreeNode.FromArray(new int?[] {3, 2, 3, null, 3, null, 1});
            TreeNode node2 = TreeNode.FromArray(new int?[] { 3, 4, 5, 1, 3, null, 1 });
            var a = Rob(node);
            var b = Rob(node2);
        }
    }
}