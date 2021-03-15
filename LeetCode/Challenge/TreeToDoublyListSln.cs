using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Challenge
{
    class Node
    {
        public int val;
        public Node left;
        public Node right;

        public Node()
        {
        }

        public Node(int _val)
        {
            val = _val;
            left = null;
            right = null;
        }

        public Node(int _val, Node _left, Node _right)
        {
            val = _val;
            left = _left;
            right = _right;
        }
    }

    class TreeToDoublyListSln : ISolution
    {
        private Node prev, head;

        public Node TreeToDoublyList(Node root)
        {
            if (root == null) return null;
            ConvertNode(root);
            head.left = prev;
            prev.right = head;

            return head;
        }

        private void ConvertNode(Node root)
        {
            if (root == null)
            {
                return;
            }

            ConvertNode(root.left);
            if (prev != null)
            {
                prev.right = root;
            }
            else
            {
                head = root;
            }

            root.left = prev;
            prev = root;

            ConvertNode(root.right);
        }

        public string MinRemoveToMakeValid(string s)
        {
            //1. count (
            //2. if ), and no valid match remove it
            //3. if count ( > 0 , remove it
            List<int> leftList = new List<int>();
            List<int> removeList = new List<int>();
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == '(')
                {
                    leftList.Add(i);
                }

                if (s[i] == ')')
                {
                    if (leftList.Count > 0)
                    {
                        leftList.RemoveAt(0);
                    }
                    else
                    {
                        //remove it
                        removeList.Add(i);
                    }
                }
            }

            removeList.AddRange(leftList);
            HashSet<int> hs = new HashSet<int>(removeList);
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < s.Length; i++)
            {
                if (!hs.Contains(i))
                {
                    sb.Append(s[i]);
                }
            }

            return sb.ToString();
        }

        public void Execute()
        {
            TreeToDoublyList(new Node(4, new Node(-6, new Node(-8), null), null));
        }
    }
}