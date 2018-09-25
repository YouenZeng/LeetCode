using System;
using System.Collections.Generic;
using System.Linq;
using LeetCode.Leets;

namespace LeetCode.LeetAgain
{
    class FindSecondMinimumValueSln : ISolution
    {
        private HashSet<int> hs = new HashSet<int>();
        public int FindSecondMinimumValue(TreeNode root)
        {
            if (root.left == null) return -1;
            FindMin(root);
            var arr = hs.ToArray();
            if (arr.Length == 1) return -1;
            Array.Sort(arr);
            return arr[1];

        }
        private void FindMin(TreeNode root)
        {
            hs.Add(root.val);
            if (root.left == null) return;

            FindMin(root.left);
            FindMin(root.right);
        }

        public void Execute()
        {
            throw new NotImplementedException();
        }
    }
}

