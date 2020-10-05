using System;
using System.Collections.Generic;

namespace LeetCode.LeetAgain
{
    public class LRUCache : ISolution
    {
        private readonly int _capacity;
        private readonly Dictionary<int, int> _kvStore = new Dictionary<int, int>();
        private readonly Dictionary<int, LinkedListNode<int>> _kLinkStore = new Dictionary<int, LinkedListNode<int>>();
        private readonly LinkedList<int> _linkedList = new LinkedList<int>();

        public LRUCache(int capacity)
        {
            _capacity = capacity;
        }

        public int Get(int key)
        {
            if (_kvStore.ContainsKey(key))
            {
                //refresh
                var node = _kLinkStore[key];
                _linkedList.Remove(node);
                var newNode = new LinkedListNode<int>(node.Value);
                _kLinkStore[key] = newNode;
                _linkedList.AddFirst(newNode);

                return _kvStore[key];
            }

            return -1;
        }

        public void Put(int key, int value)
        {
            if (_kvStore.ContainsKey(key))
            {
                _kvStore[key] = value;
                //refresh
                var node = _kLinkStore[key];
                _linkedList.Remove(node);
                var newNode = new LinkedListNode<int>(node.Value);
                _kLinkStore[key] = newNode;
                _linkedList.AddFirst(newNode);

                return;
            }

            if (_kvStore.Count >= _capacity)
            {
                var last = _linkedList.Last;
                _linkedList.RemoveLast();
                _kvStore.Remove(last.Value);
            }

            var newAdded = new LinkedListNode<int>(key);
            _kvStore[key] = value;
            _kLinkStore[key] = newAdded;
            _linkedList.AddFirst(newAdded);
        }

        public void Execute()
        {
            var lru = new LRUCache(2);
            lru.Put(2,1);
            lru.Put(2,2);

            Console.WriteLine(lru.Get(2));

            lru.Put(1,1);
            lru.Put(4,1);
            Console.WriteLine(lru.Get(2));
        }
    }
}