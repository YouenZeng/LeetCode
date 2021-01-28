namespace LeetCode.Challenge
{
    public class Trie
    {
        private TrieNode root;

        /** Initialize your data structure here. */
        public Trie()
        {
            root = new TrieNode();
        }

        /** Inserts a word into the trie. */
        public void Insert(string word)
        {
            TrieNode node = root;

            for (int i = 0; i < word.Length; i++)
            {
                if (!node.ContainsKey(word[i]))
                {
                    node.Put(word[i], new TrieNode());
                }

                node = node.Get(word[i]);
            }

            node.SetEnd();
        }

        /** Returns if the word is in the trie. */
        public bool Search(string word)
        {
            TrieNode node = SearchPrefix(word);
            return node != null && node.IsEnd();
        }

        private TrieNode SearchPrefix(string word)
        {
            TrieNode node = root;
            for (int i = 0; i < word.Length; i++)
            {
                if (node.ContainsKey(word[i]))
                {
                    node = node.Get(word[i]);
                }
                else
                {
                    return null;
                }
            }

            return node;
        }

        /** Returns if there is any word in the trie that starts with the given prefix. */
        public bool StartsWith(string prefix)
        {
            TrieNode node = SearchPrefix(prefix);
            return node != null;
        }
    }

    class TrieNode
    {
        // R links to node children
        private TrieNode[] links;

        private int R = 26;

        private bool isEnd;

        public TrieNode()
        {
            links = new TrieNode[R];
        }

        public bool ContainsKey(char ch)
        {
            return links[ch - 'a'] != null;
        }

        public TrieNode Get(char ch)
        {
            return links[ch - 'a'];
        }

        public void Put(char ch, TrieNode node)
        {
            links[ch - 'a'] = node;
        }

        public void SetEnd()
        {
            isEnd = true;
        }

        public bool IsEnd()
        {
            return isEnd;
        }
    }
}