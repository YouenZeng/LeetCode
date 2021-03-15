using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Challenge
{
    class KillProcessSln : ISolution
    {
        public IList<int> KillProcess(IList<int> pid, IList<int> ppid, int kill)
        {
            //union find
            parent = new int[5001];
            Array.Fill(parent, -1);

            for (int i = 0; i < pid.Count; i++)
            {
                if (pid[i] == kill)
                {
                    continue;
                }
                Union(pid[i], ppid[i]);
            }

            IList<int> result = new List<int>();
            for (int i = 0; i < parent.Length; i++)
            {
                if (parent[i]!=-1 && Find(parent[i]) == kill)
                {
                    result.Add(i);
                }
            }
            result.Add(kill);
            return result;
        }

        int[] parent;
        private int Find(int x)
        {
            if (parent[x] == -1)
            {
                return x;
            }
            return Find(parent[x]);
        }
        private void Union(int x, int y)
        {
            int x1 = Find(x);
            int y1 = Find(y);

            parent[x1] = y1;
        }

        public void Execute()
        {
            KillProcess(
                new List<int>() { 6, 1, 3, 9, 5, 8, 7, 4, 10 }, 
                new List<int>() { 5, 8, 4, 5, 10, 5, 3, 8, 0 }, 
                10);
        }
    }
}
