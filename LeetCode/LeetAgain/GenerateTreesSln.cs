using LeetCode.Leets;
using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.LeetAgain
{
    class GenerateTreesSln : ISolution
    {

        public IList<TreeNode> GenerateTrees(int n)
        {
            if (n == 0) return new List<TreeNode>();
            return GenerateTreeRange(1, n);
        }

        private IList<TreeNode> GenerateTreeRange(int from, int to)
        {
            IList<TreeNode> result = new List<TreeNode>();

            if (from > to)
            {
                result.Add(null);
                return result;
            }

            if (from == to)
            {
                result.Add(new TreeNode(from));
                return result;
            }

            IList<TreeNode> leftNode;
            IList<TreeNode> rightNode;

            for (int i = from; i <= to; i++)
            {
                leftNode = GenerateTreeRange(from, i - 1);
                rightNode = GenerateTreeRange(i + 1, to);

                foreach (TreeNode left in leftNode)
                {
                    foreach (TreeNode right in rightNode)
                    {
                        TreeNode root = new TreeNode(i);
                        root.left = left;
                        root.right = right;
                        result.Add(root);
                    }
                }
            }
            return result;
        }

        public void Execute()
        {
            throw new NotImplementedException();
        }
    }
}
