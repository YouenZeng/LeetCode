using System;
using System.Collections.Generic;
using LeetCode.Leets;

namespace LeetCode.Lof
{
    class BuildTreeSkn : ISolution
    {
        Dictionary<int, int> inOrderIndex = new Dictionary<int, int>();

        public TreeNode BuildTree(int[] preorder, int[] inorder)
        {
            for (int i = 0; i < inorder.Length; i++)
            {
                inOrderIndex[inorder[i]] = i;
            }

            var r = BuildTree(preorder, inorder, 0, preorder.Length - 1, 0, inorder.Length - 1);
            return r;
        }

        public TreeNode BuildTree(int[] preorder, int[] inorder, int preStart, int preEnd, int inStart, int inEnd)
        {
            if (preStart >= preorder.Length || preStart > preEnd)
                return null;

            var rootIndex = inOrderIndex[preorder[preStart]];

            var root = new TreeNode(preorder[preStart]);

            int leftLength = rootIndex - inStart;

            root.left = BuildTree(preorder, inorder, preStart + 1, preStart + leftLength, inStart, rootIndex - 1);
            root.right = BuildTree(preorder, inorder, preStart + leftLength + 1, preEnd, rootIndex + 1, inEnd);

            return root;
        }

        public void Execute()
        {
            int[] preorder = new int[] { 1, 2,3 };
            int[] inorder = new int[] { 3,2,1 };

            BuildTree(preorder, inorder);
        }
    }
}
