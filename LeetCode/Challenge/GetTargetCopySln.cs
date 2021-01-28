using System;
using System.Collections.Generic;
using System.Text;
using LeetCode.Leets;

namespace LeetCode.Challenge
{
    class GetTargetCopySln : ISolution
    {
        public TreeNode GetTargetCopy(TreeNode original, TreeNode cloned, TreeNode target)
        {
            Stack<TreeNode> originalStack = new Stack<TreeNode>();
            Stack<TreeNode> clonedStack = new Stack<TreeNode>();

            while (original != null || originalStack.Count > 0)
            {
                if (original != null && original == target)
                {
                    return cloned;
                }
                while (original != null)
                {
                    originalStack.Push(original);
                    clonedStack.Push(cloned);

                    cloned = cloned.left;
                    original = original.left;
                }

                var nodeO = originalStack.Pop();
                original = nodeO.right;

                var nodeC = clonedStack.Pop();
                cloned = nodeC.right;

              
            }

            return null;
        }

        public void Execute()
        {
            throw new NotImplementedException();
        }
    }
}