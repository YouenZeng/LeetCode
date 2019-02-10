using System;
using System.Collections.Generic;

namespace LeetCode.LeetAgain
{
    internal class CanIWinSln : ISolution
    {
        public bool CanIWin(int maxChoosableInteger, int desiredTotal)
        {
            int sum = (1 + maxChoosableInteger) * maxChoosableInteger;
            if (maxChoosableInteger >= desiredTotal) return true;
            if (sum < desiredTotal) return false;
            if (sum == desiredTotal) return sum % 2 == 0;

            Dictionary<int, bool> visisted = new Dictionary<int, bool>();


            return Dfs(visisted, maxChoosableInteger, desiredTotal, 0);
        }

        private bool Dfs(Dictionary<int, bool> visited, int maxChoosableInteger, int desiredTotal, int currentTotal)
        {
            if (desiredTotal <= 0) return false;

            if (visited.ContainsKey(currentTotal)) return visited[currentTotal];

            for (int i = 0; i < maxChoosableInteger; i++)
            {
                //i+1 not picked
                if ((currentTotal & (1 << i)) == 0 &&
                    //and dfs(oppeonent) cant reach next state , then I win.
                    !Dfs(visited, maxChoosableInteger, desiredTotal - i - 1, currentTotal | (1 << i)))
                {
                    visited.Add(currentTotal, true);
                    return true;
                }
            }

            visited.Add(currentTotal, false);
            return false;
        }
        public void Execute()
        {
            CanIWin(4, 6);
        }
    }
}
