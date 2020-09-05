using System.Collections.Generic;

namespace LeetCode.LeetAgain
{
    class CombineSln : ISolution
    {
        private readonly IList<IList<int>> result = new List<IList<int>>();

        public IList<IList<int>> Combine(int n, int k)
        {
            if (n < k)
                return result;
            var stack = new Stack<int>();
            Dfs(stack, 1, k, n);
            return result;
        }

        private void Dfs(Stack<int> currentStack, int c, int k, int n)
        {
            if (currentStack.Count == k)
            {
                result.Add(new List<int>(currentStack));
                return;
            }

            for (int i = c; i <= n; i++)
            {
                currentStack.Push(i);
                Dfs(currentStack, i + 1, k, n);
                currentStack.Pop();
            }
        }

        public void Execute()
        {
            Combine(4, 4);
        }
    }
}