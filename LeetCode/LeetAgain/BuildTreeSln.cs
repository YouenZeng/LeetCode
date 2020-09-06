using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using LeetCode.Leets;

namespace LeetCode.LeetAgain
{
    public class BuildTreeSln : ISolution
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
            if (inEnd < 0 || inStart > inEnd)
                return null;


            var rootIndex = inOrderIndex[preorder[preStart]];

            var root = new TreeNode(preorder[preStart]);

            int leftLength = inOrderIndex[preorder[preStart]] - inStart;

            root.left = BuildTree(preorder, inorder, preStart + 1, preStart + leftLength, inStart, rootIndex - 1);
            root.right = BuildTree(preorder, inorder, preStart + leftLength + 1, preEnd, rootIndex + 1, inEnd);

            return root;
        }

        public void Execute()
        {
            BuildTree(new[] {3}, new[] { 3});
            BuildTree(new[] {3, 9, 8}, new[] {9, 3, 8});
            BuildTree(new[] {3, 9, 8, 20, 15, 7}, new[] {9, 8, 3, 15, 20, 7});
        }
    }
}