using System;
using System.Collections.Generic;
using System.Linq;
using LeetCode.Leets;

namespace LeetCode.Challenge
{
    class VerticalTraversalSln : ISolution
    {
        public IList<IList<int>> VerticalTraversal(TreeNode root)
        {
            Stack<Tuple<int, int, TreeNode>> stack = new Stack<Tuple<int, int, TreeNode>>();

            int idx = 0;
            Dictionary<int, Dictionary<int, List<int>>> dict = new Dictionary<int, Dictionary<int, List<int>>>();
            int layer = 0;
            while (root != null || stack.Count > 0)
            {
                while (root != null)
                {
                    stack.Push(new Tuple<int, int, TreeNode>(idx, layer, root));
                    root = root.left;
                    layer++;
                    idx--;
                }

                Tuple<int, int, TreeNode> node = stack.Pop();
                if (!dict.ContainsKey(node.Item1))
                {
                    dict[node.Item1] = new Dictionary<int, List<int>>();
                }

                if (!dict[node.Item1].ContainsKey(node.Item2))
                {
                    dict[node.Item1][node.Item2] = new List<int>();
                }

                dict[node.Item1][node.Item2].Add(node.Item3.val);

                root = node.Item3.right;
                idx = node.Item1 + 1;
                layer = node.Item2 + 1;
            }

            List<IList<int>> result = new List<IList<int>>();

            IOrderedEnumerable<KeyValuePair<int, Dictionary<int, List<int>>>> orderDict = dict.OrderBy(d => d.Key);
            foreach (KeyValuePair<int, Dictionary<int, List<int>>> keyValuePair in orderDict)
            {
                IOrderedEnumerable<KeyValuePair<int, List<int>>> orderLayer = keyValuePair.Value.OrderBy(d => d.Key);
                List<int> t = new List<int>();
                foreach (KeyValuePair<int, List<int>> valuePair in orderLayer)
                {
                    valuePair.Value.Sort();
                    t.AddRange(valuePair.Value);
                }

                result.Add(t);
            }

            return result;
        }


        public void Execute()
        {
            TreeNode root = TreeNode.FromArray(new int?[] {1, 2, 3, 4, 6, 5, 7});
            VerticalTraversal(root);
        }
    }
}