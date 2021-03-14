using System.Collections.Generic;
using LeetCode.Leets;

namespace LeetCode.LeetAgain
{
    public class PostorderTraversalSln : ISolution
    {
        private IList<int> result = new List<int>();

        public IList<int> PostorderTraversal(TreeNode root)
        {
            if (root == null)
            {
                return result;
            }

            PostorderTraversal(root.left);
            PostorderTraversal(root.right);
            result.Add(root.val);

            return result;
        }

        public IList<int> PostorderTraversalII(TreeNode root)
        {
            var r = new List<int>();
            if (root == null)
            {
                return r;
            }

            Stack<TreeNode> stack = new Stack<TreeNode>();
            HashSet<TreeNode> visisted = new HashSet<TreeNode>();
            stack.Push(root);
            while (stack.Count > 0)
            {
                var node = stack.Pop();
                if ((node.left == null || visisted.Contains(node.left)) &&
                    (node.right == null || visisted.Contains(node.right)))
                {
                    r.Add(node.val);
                    visisted.Add(node);
                    continue;
                }

                stack.Push(node);
                if (node.right != null)
                {
                    stack.Push(node.right);
                }

                if (node.left != null)
                {
                    stack.Push(node.left);
                }
            }

            return r;
        }

        public void Execute()
        {
            var r = new TreeNode(1, new TreeNode(11, new TreeNode(22)), new TreeNode(2, null, new TreeNode(3)));
            PostorderTraversalII(r);
        }
    }
}