using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Challenge
{
    class ConstructDistancedSequenceSln : ISolution
    {
        public int[] ConstructDistancedSequence(int n)
        {
            int len = 2 * n - 1;
            int[] result = new int[len];
            bool[] visited = new bool[len];

            Dfs(result, n, 0, visited, len);
            for (int i = 0; i < len; i++)
            {
                if (result[i] == 0)
                {
                    result[i] = 1;
                }
            }

            return result;
        }

        private bool Dfs(int[] result, int n, int startIndex, bool[] visited, int len)
        {
            if (n == 1) return true;
            if (result[startIndex] != 0)
            {
                return Dfs(result, n, 1 + startIndex, visited, len);
            }

            if (visited[n] == false && result[startIndex] == 0 && result[startIndex + n] == 0)
            {
                result[startIndex] = n;
                result[startIndex + n] = n;
                visited[n] = true;

                if (Dfs(result, n - 1, startIndex + 1, visited, len))
                {
                    return true;
                }
                else
                {
                    result[startIndex] = 0;
                    result[startIndex + n] = 0;
                    visited[n] = false;
                }
            }


            return false;
        }

        public void Execute()
        {
            ConstructDistancedSequence(5);
        }
    }
}