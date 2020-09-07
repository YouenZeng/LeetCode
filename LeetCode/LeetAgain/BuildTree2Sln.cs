using System;
using System.Collections.Generic;
using LeetCode.Leets;

namespace LeetCode.LeetAgain
{
    public class BuildTree2Sln : ISolution
    {
        //public TreeNode BuildTree(int[] inorder, int[] postorder)
        //{


        //    throw new NotImplementedException();
        //}

        //use dict to quick search
        Dictionary<int, int> inOrderIndex = new Dictionary<int, int>();

        public TreeNode BuildTree(int[] inorder, int[] postOrder)
        {
            for (int i = 0; i < inorder.Length; i++)
            {
                inOrderIndex[inorder[i]] = i;
            }

            var r = BuildTree(postOrder, inorder, 0, postOrder.Length - 1, 0, inorder.Length - 1);
            return r;
        }

        public TreeNode BuildTree(int[] postOrder, int[] inorder, int postStart, int postEnd, int inStart, int inEnd)
        {
            if (postEnd < 0 || postStart > postEnd)
                return null;

            var rootIndex = inOrderIndex[postOrder[postEnd]];

            var root = new TreeNode(postOrder[postEnd]);

            int leftLength = inOrderIndex[postOrder[postEnd]] - inStart;

            root.left = BuildTree(postOrder, inorder, postStart, postStart + leftLength - 1, inStart, rootIndex - 1);
            root.right = BuildTree(postOrder, inorder, postStart + leftLength , postEnd - 1, rootIndex + 1, inEnd);

            return root;
        }


        public void Execute()
        {
            BuildTree(new[] {9, 3, 15, 20, 7}, new[] {9, 15, 7, 20, 3});
            BuildTree(new[] {3, 8}, new[] {8, 3});
            BuildTree(new[] {9, 3, 8}, new[] {9, 8, 3});
            BuildTree(new[] {9, 8, 3, 15, 20, 7}, new[] {8, 9, 15, 7, 20, 3});
        }
    }
}