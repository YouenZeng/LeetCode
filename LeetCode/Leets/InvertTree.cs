using System;

namespace LeetCode.Leets
{
    public class InvertTreeExe : ISolution
    {
        // Definition for a binary tree node.

        public TreeNode InvertTree(TreeNode root)
        {
            if (root == null)
                return null;
            TreeNode node = root.left;
            root.left = root.right;
            root.right = node;
            InvertTree(root.left);
            InvertTree(root.right);
            return root;
        }

        public void Execute()
        {
            throw new NotImplementedException();
        }
    }

    public class TreeNode : Node<int, TreeNode>
    {
        public TreeNode(int val):base(val)
        {
            this.val = val;
        }

        public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null) : base(val)
        {
            this.val = val;
            this.left = left;
            this.right = right;
        }
    }

    public abstract class Node<T, V> where T : struct where V : Node<T, V>
    { // in C# 8.0 you can use 'where T: notnull'
        public T val;
        public V left;
        public V right;

        protected Node(T val)
        {
            this.val = val;
        }

        public static V Instantiate(T val)
        {
            return (V)Activator.CreateInstance(typeof(V), val);
        }

        public static V FromArray(T?[] array)
        {
            V GetFromArray(int index)
            {
                if (index >= array.Length || array[index] == null) return null;
                var node = Instantiate((T)array[index]);
                node.left = GetFromArray(index * 2 + 1);
                node.right = GetFromArray(index * 2 + 2);

                return node;
            }

            return GetFromArray(0);
        }

        public T?[] ToArray()
        {
            T?[] array = new T?[10];

            int AddToArray(Node<T, V> node, int index)
            {
                if (index >= array.Length) Array.Resize(ref array, array.Length * 2);
                if (node is null)
                {
                    array[index] = null;
                    return -1;
                }
                else
                {
                    int maxSize = index + 1;
                    array[index] = node.val;
                    maxSize = Math.Max(maxSize, AddToArray(node.left, index * 2 + 1));
                    maxSize = Math.Max(maxSize, AddToArray(node.right, index * 2 + 2));

                    return maxSize;
                }
            }

            int size = AddToArray(this, 0);
            Array.Resize(ref array, size);

            return array;
        }
    }
}