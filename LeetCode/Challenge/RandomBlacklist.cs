using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Challenge
{
    class RandomBlacklist : ISolution
    {
        Dictionary<int, int> map = new Dictionary<int, int>();
        private readonly int randomCount = 0;
        private readonly Random random = null;


        public RandomBlacklist(int N, int[] blacklist)
        {
            int b = blacklist.Length - 1;
            int n = N - 1;
            HashSet<int> blackHs = new HashSet<int>(blacklist);
            randomCount = N - blacklist.Length;
            while (b >= 0)
            {
                while (b >= 0 && blacklist[b] >= randomCount)
                {
                    b--;
                }

                while (blackHs.Contains(n))
                {
                    n--;
                }

                if (b >= 0)
                {
                    map[blacklist[b]] = n;
                    b--;
                    n--;
                }
            }


            random = new Random();
        }

        public int Pick()
        {
            int rd = random.Next(0, randomCount);
            if (map.ContainsKey(rd))
            {
                rd = map[rd];
            }

            return rd;
        }

        public void Execute()
        {
            throw new NotImplementedException();
        }
    }
}