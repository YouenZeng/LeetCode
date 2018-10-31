using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.LeetAgain
{
    class CanIWinSln : ISolution
    {
        public bool CanIWin(int maxChoosableInteger, int desiredTotal)
        {
            Dictionary<int, HashSet<int>> dict = new Dictionary<int, HashSet<int>();

            for (int i = 0; i < desiredTotal; i++)
            {
                for (int j = 0; j < maxChoosableInteger; j++)
                {
                    if (dict.ContainsKey(i) == false)
                    {
                        dict.Add(i, new HashSet<int>() { 1 });
                    }
                }
            }
            throw new NotImplementedException();
        }
        public void Execute()
        {
            throw new NotImplementedException();
        }
    }
}
