using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.LeetAgain
{
    class WordBreakSln : ISolution
    {
        public bool WordBreak(string s, IList<string> wordDict)
        {
            int stringLength = s.Length;
            bool[] dp = new bool[stringLength + 1];

            dp[0] = true;

            for (int i = 1; i <= stringLength; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    if (dp[j] && wordDict.Contains(s.Substring(j, i - j)))
                    {
                        dp[i] = true;
                        break;
                    }
                }
            }

            return dp[stringLength];
        }
        public void Execute()
        {
            WordBreak("leetcodere", new[] { "leet", "co","d","e", "re"});
        }
    }
}
