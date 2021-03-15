using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode.Challenge
{
    public class MyHashMap
    {
        private int capacity = 10007;
        private List<Tuple<int, int>>[] _content;

        /** Initialize your data structure here. */
        public MyHashMap()
        {
            _content = new List<Tuple<int, int>>[capacity + 1];
        }
        public int RemovePalindromeSub(string s)
        {
            var s1 =s.Reverse();
            //Console.WriteLine((new StringBuilder(s).ToString().Reverse()));
            return string.IsNullOrEmpty(s) ? 0 : (
                s == new string(s.Reverse().ToArray()) ? 1 : 2
            );

        }

        /** value will always be non-negative. */
        public void Put(int key, int value)
        {
            

            int hash = key.GetHashCode() % capacity;
            Remove(key);

            _content[hash].Add(new Tuple<int, int>(key, value));
        }

        private Tuple<int, int> GetInternal(int key)
        {
            int hash = key.GetHashCode() % capacity;
            if (_content[hash] == null)
            {
                return null;
            }

            Tuple<int, int> item = _content[hash].First(c => c.Item1 == key);

            return item;
        }

        /** Returns the value to which the specified key is mapped, or -1 if this map contains no mapping for the key */
        public int Get(int key)
        {
            Tuple<int, int> item = GetInternal(key);
            if (item == null)
            {
                return -1;
            }

            return item.Item2;
        }

        /** Removes the mapping of the specified value key if this map contains a mapping for the key */
        public void Remove(int key)
        {
            int hash = key.GetHashCode() % capacity;
            if (_content[hash] == null)
            {
                _content[hash] = new List<Tuple<int, int>>();
            }

            Tuple<int, int> item = _content[hash].First(c => c.Item1 == key);
            if (item != null)
            {
                _content[hash].Remove(item);
            }
        }
    }
}