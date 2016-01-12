using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Leets
{
    class LowestCommonAncestorSln : ISolution
    {
        public TreeNode LowestCommonAncestor(TreeNode root, TreeNode p, TreeNode q)
        {
            int big, small;
            if (p.val > q.val)
            {
                big = p.val;
                small = q.val;
            }
            else
            {
                big = q.val;
                small = p.val;
            }

            if (big < root.val)
            {
                return LowestCommonAncestor(root.left, p, q);
            }
            if (small > root.val)
            {
                return LowestCommonAncestor(root.right, p, q);
            }
            return root;
        }
        public void Execute()
        {
            throw new NotImplementedException();
        }
    }
}
