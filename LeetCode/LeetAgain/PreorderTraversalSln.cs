using System.Collections.Generic;
using LeetCode.Leets;

namespace LeetCode.LeetAgain
{
    public class PreorderTraversalSln : ISolution
    {
        private IList<int> result = new List<int>();

        public IList<int> PreorderTraversal(TreeNode root)
        {
            if (root == null)
                return result;
            result.Add(root.val);
            //PreorderTraversal(root);
            PreorderTraversal(root.left);
            PreorderTraversal(root.right);
            return result;
        }

        public IList<int> PreorderTraversalII(TreeNode root)
        {
            IList<int> r = new List<int>();
            if (root == null)
            {
                return r;
            }

            Stack<TreeNode> stack = new Stack<TreeNode>();
            stack.Push(root);

            while (stack.Count > 0)
            {
                var n = stack.Pop();
                r.Add(n.val);
                if (n.right != null)
                {
                    stack.Push(n.right);
                }

                if (n.left != null)
                {
                    stack.Push(n.left);
                }
            }


            return r;
        }

        public void Execute()
        {
            var r = new TreeNode(1, new TreeNode(11, new TreeNode(22)), new TreeNode(2, null, new TreeNode(3)));
            PreorderTraversalII(r);
        }
    }
}