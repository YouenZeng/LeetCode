using System;
using System.Collections.Generic;
using System.Text;
using LeetCode.Leets;

namespace LeetCode.Challenge
{
    class AddOneRowSln:ISolution
    {
        public TreeNode AddOneRow(TreeNode root, int v, int d)
        {
            //DFS
            if (root == null)
            {
                return root;
            }

            if (d == 2)
            {
                root.left = new TreeNode(v, root.left, null);
                root.right = new TreeNode(v, null, root.right);
            }
            else
            {
                AddOneRow(root.left, v, d - 1);
                AddOneRow(root.right, v, d - 1);
            }

            return root;
        }


        public void Execute()
        {
            var node = TreeNode.FromArray(new int?[] {1,2,3,4,null,null,null});
            var r = AddOneRow(node, 5, 4);
        }
    }
}
