using System.Collections.Generic;
using LeetCode.Leets;

namespace LeetCode.LeetAgain
{
    public class SumNumbersSln : ISolution
    {
        public int SumNumbers2(TreeNode root)
        {
            return Dfs(root, 0);
        }

        private int Dfs(TreeNode root, int v)
        {
            if (root == null)
            {
                return 0;
            }

            if (root.left == null && root.right == null)
            {
                return v * 10 + root.val;
            }

            return Dfs(root.left, v * 10 + root.val) + Dfs(root.right, v * 10 + root.val);
        }

        public int SumNumbers(TreeNode root)
        {
            //DFS
            int result = 0;
            if (root == null)
            {
                return result;
            }

            Stack<KeyValuePair<TreeNode, int>> stack = new Stack<KeyValuePair<TreeNode, int>>();
            stack.Push(new KeyValuePair<TreeNode, int>(root, 0));

            while (stack.Count > 0)
            {
                var n = stack.Pop();
                var node = n.Key;
                var v = n.Value;
                if (node != null)
                {
                    v = v * 10 + node.val;
                    if (node.left == null && node.right == null)
                    {
                        result += v;
                    }

                    stack.Push(new KeyValuePair<TreeNode, int>(node.left, v));
                    stack.Push(new KeyValuePair<TreeNode, int>(node.right, v));
                }
            }

            return result;
        }

        public void Execute()
        {
            var node = new TreeNode(4, new TreeNode(9, new TreeNode(5), new TreeNode(1)), new TreeNode(0));
            var node2 = new TreeNode(1, new TreeNode(5), new TreeNode(1, null, new TreeNode(6)));
            var a = SumNumbers2(node);
        }
    }
}