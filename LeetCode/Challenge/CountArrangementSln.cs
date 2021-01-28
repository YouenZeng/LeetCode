using System;

namespace LeetCode.Challenge
{
    class CountArrangementSln : ISolution
    {
        private int count = 0;

        public int CountArrangement(int n)
        {
            bool[] visited = new bool[n + 1];
            Dfs(visited, 1, n);
            return count;
        }

        private void Dfs(bool[] visited, int currentIndex, int n)
        {
            if (currentIndex > n)
            {
                count++;
                return;
            }

            for (int i = 1; i <= n; i++)
            {
                if (!visited[i] && (currentIndex % i == 0 || i % currentIndex == 0))
                {
                    visited[i] = true;
                    Dfs(visited, currentIndex + 1, n);
                    visited[i] = false;
                }
            }
        }

        public void Execute()
        {
            throw new NotImplementedException();
        }
    }
}