using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Challenge
{
    class MaxLengthSln : ISolution
    {
        public int MaxLength(IList<string> arr)
        {
            List<int> bm = PrepareBitMap(arr);
            for (int i = 0; i < arr.Count; i++)
            {
                Dfs(bm, arr, i, bm[i], arr[i].Length);
            }


            return max;
        }

        private List<int> PrepareBitMap(IList<string> arr)
        {
            List<int> bm = new List<int>();
            foreach (string s in arr)
            {
                int n = 0;
                bool duplicated = false;
                foreach (char c in s)
                {
                    if ((n | 1 << (c - 'a')) == n)
                    {
                        duplicated = true;
                        break;
                    }

                    n |= 1 << (c - 'a');
                }

                if (duplicated)
                {
                    n = int.MaxValue;
                }

                bm.Add(n);
            }

            return bm;
        }

        private int max;

        private void Dfs(List<int> bm, IList<string> arr, int idx, int current, int len)
        {
            if (current == int.MaxValue)
            {
                return;
            }

            max = Math.Max(len, max);

            if (idx == bm.Count)
            {
                return;
            }

            for (int i = 1 + idx; i < bm.Count; i++)
            {
                if ((current & bm[i]) == 0)
                {
                    Dfs(bm, arr, i, current | bm[i], len + arr[i].Length);
                }
            }
        }

        public void Execute()
        {
            MaxLength(new List<string>() {"yy", "bkhwmpbiisbldzknpm"});
            MaxLength(new List<string>() {"un", "iq", "ue"});
            MaxLength(new List<string>() {"cha", "r", "act", "ers"});
        }
    }
}