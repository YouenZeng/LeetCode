using LeetCode.Leets;
using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.LeetAgain
{
    class CodecSln : ISolution
    {
        // Encodes a tree to a single string.
        public String serialize(TreeNode root)
        {
            Queue<TreeNode> nodeTree = new Queue<TreeNode>();

            nodeTree.Enqueue(root);


            while (nodeTree.Count > 0)
            {
            }

            throw new NotImplementedException();
        }

        // Decodes your encoded data to tree.
        public TreeNode deserialize(String data)
        {
            throw new NotImplementedException();
        }

        public void Execute()
        {
            throw new NotImplementedException();
        }
    }
}