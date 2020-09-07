using System.Collections.Generic;
using LeetCode.Leets;

namespace LeetCode.LeetAgain
{
    public class RecoverTreeSln : ISolution
    {
        public void RecoverTree(TreeNode root)
        {
            //1. in-order traverse
            //2. try..

            Stack<int> stack = new Stack<int>();
            Stack<TreeNode> nodeStack = new Stack<TreeNode>();

            TreeNode first = null;
            TreeNode second = null;

            while (nodeStack.Count > 0 || root != null)
            {
                if (root != null)
                {
                    nodeStack.Push(root);
                    root = root.left;
                }
                else
                {
                    root = nodeStack.Pop();
                    stack.Push(root.val);
                    root = root.right;
                }
            }
        }

        public void Execute()
        {
            throw new System.NotImplementedException();
        }
    }
}