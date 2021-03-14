using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode.Challenge
{
    class MinimumLengthEncodingSln : ISolution
    {
        public int MinimumLengthEncoding(string[] words)
        {
            Trie trie = new Trie();
            int count = 0;
            Array.Sort(words, (s1, s2) => s2.Length.CompareTo(s1.Length));
            foreach (string word in words)
            {
                if (trie.StartWith(new string(word.Reverse().ToArray())))
                {
                    continue;
                }

                trie.Insert(new string(word.Reverse().ToArray()));
                count += word.Length + 1;
            }

            return count;
        }

        public void Execute()
        {
            MinimumLengthEncoding(new[] {"time", "mef", "bell"});
        }
    }

    class Trie
    {
        public bool IsEnd { get; set; }
        public Trie[] Next { get; set; }

        public Trie()
        {
            IsEnd = false;
            Next = new Trie[26];
        }

        public void Insert(string word)
        {
            Trie node = this;

            foreach (char c in word)
            {
                if (node.Next[c - 'a'] == null)
                {
                    node.Next[c - 'a'] = new Trie();
                }

                node = node.Next[c - 'a'];
            }

            node.IsEnd = true;
        }


        public bool Search(string word)
        {
            Trie node = this;
            foreach (char c in word)
            {
                node = node.Next[c - 'a'];
                if (node == null)
                {
                    return false;
                }
            }

            return node.IsEnd;
        }

        public bool StartWith(string prefix)
        {
            Trie node = this;
            foreach (char c in prefix)
            {
                node = node.Next[c - 'a'];
                if (node == null)
                {
                    return false;
                }
            }

            return true;
        }
    }
}