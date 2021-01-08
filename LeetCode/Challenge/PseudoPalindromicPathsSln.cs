using System.Collections.Generic;
using LeetCode.Leets;

namespace LeetCode.Challenge
{
    class PseudoPalindromicPathsSln : ISolution
    {
        private int result;
        public int PseudoPalindromicPaths(TreeNode root)
        {
            Dictionary<int, int> visited = new Dictionary<int, int>();
            visited[root.val] = 1;
            Dfs(root, visited);
            return result;
        }

        private void Dfs(TreeNode root, Dictionary<int, int> visited)
        {
            if (root.left == null && root.right == null)
            {
                if (IsPalindromic(visited))
                {
                    result++;
                }

                return;
            }

            if (root.left != null)
            {
                if (!visited.ContainsKey(root.left.val))
                {
                    visited[root.left.val] = 0;
                }
                visited[root.left.val]++;
                Dfs(root.left, visited);
                visited[root.left.val]--;
            }

            if (root.right != null)
            {
                if (!visited.ContainsKey(root.right.val))
                {
                    visited[root.right.val] = 0;
                }
                visited[root.right.val]++;
                Dfs(root.right, visited);
                visited[root.right.val]--;
            }
        }

        private bool IsPalindromic(Dictionary<int, int> visited)
        {
            int oddCount = 0;
            foreach (KeyValuePair<int, int> keyValuePair in visited)
            {
                if (keyValuePair.Value % 2 == 1)
                {
                    oddCount++;
                }

                if (oddCount > 1)
                {
                    return false;
                }
            }

            return true;
        }



        public void Execute()
        {
            PseudoPalindromicPaths(TreeNode.FromArray(new int?[] { 2, 3, 1, 3, 1, null, 1 }));
        }
    }
}
