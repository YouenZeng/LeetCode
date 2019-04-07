using System.Collections.Generic;

namespace LeetCode.LeetAgain
{
    class RemoveStonesSln : ISolution
    {
        public int RemoveStones(int[][] stones)
        {
            for (int i = 0; i < stones.GetLength(0); i++)
            {
                Union(stones[i][0], 10000+stones[i][1]);
            }
            return stones.GetLength(0) - Moves;
            //MAKE-SETS(G)
            //FIND(u)
            //UNION(u, v)
        }

        private readonly Dictionary<int, int> _cache = new Dictionary<int, int>();
        public int Moves;
        private int Find(int x)
        {
            if (!_cache.ContainsKey(x))
            {
                Moves++;
                _cache.Add(x, x);
            }

            if (_cache[x] != x)
            {
                _cache[x] = Find(_cache[x]);
            }

            return _cache[x];
        }

        private void Union(int x, int y)
        {
            x = Find(x);
            y = Find(y);

            if (x != y)
            {
                _cache[x] = y;
                Moves--;
            }
        }

        public void Execute()
        {
            RemoveStones(new[] { new[] { 0, 0 }, new[] { 0, 1 }, new[] { 1, 0 }, new[] { 1, 2 }, new[] { 2, 1 }, new[] { 2, 2 } });
        }
    }
}
