using System;

namespace LeetCode.LeetAgain
{
    class CanReachJumpGameIIISln : ISolution
    {
        public bool CanReach(int[] arr, int start)
        {
            bool[] visited = new bool[arr.Length];
            return CanReach(arr, start, visited);
        }

        private bool CanReach(int[] arr, int start, bool[] visited)
        {
            if (start < 0 || start >= arr.Length)
            {
                return false;
            }
            if (arr[start] == 0)
            {
                return true;
            }
            if (visited[start])
            {
                return false;
            }
            visited[start] = true;

            return CanReach(arr, start - arr[start], visited) || CanReach(arr, start + arr[start], visited);
        }

        public void Execute()
        {
            Console.WriteLine(CanReach(new int[] { 2, 2, 3, 2, 3 }, 3));
            Console.WriteLine(CanReach(new int[] { 4, 2, 3, 0, 3, 1, 2 }, 0));
            Console.WriteLine(CanReach(new int[] { 3, 0, 2, 1, 2 }, 2));
        }
    }
}
