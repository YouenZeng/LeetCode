using System.Collections.Generic;

namespace LeetCode.LeetAgain
{
    class WordBreakSln : ISolution
    {
        public bool WordBreak139(string s, IList<string> wordDict)
        {
            HashSet<int> hs = new HashSet<int> {0};
            for (int i = 1; i <= s.Length; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    if (hs.Contains(j) && wordDict.Contains(s.Substring(j, i - j)))
                    {
                        hs.Add(i);
                        break;
                    }
                }
            }

            return hs.Contains(s.Length);
        }

        Dictionary<string, List<string>> dict = new Dictionary<string, List<string>>();

        /// <summary>
        /// 140
        /// </summary>
        /// <param name="s"></param>
        /// <param name="wordDict"></param>
        /// <returns></returns>
        public IList<string> WordBreak(string s, IList<string> wordDict)
        {
            List<string> res = new List<string>();
            if (string.IsNullOrEmpty(s))
            {
                return res;
            }

            if (dict.ContainsKey(s))
            {
                return dict[s];
            }

            if (wordDict.Contains(s))
            {
                res.Add(s);
            }

            for (int i = 1; i < s.Length; i++)
            {
                string t = s.Substring(i);
                if (wordDict.Contains(t))
                {
                    IList<string> temp = WordBreak(s.Substring(0, i), wordDict);
                    if (temp.Count > 0)
                    {
                        for (int j = 0; j < temp.Count; j++)
                        {
                            res.Add(temp[j] + " " + t);
                        }
                    }
                }
            }

            dict[s] = res;
            return res;
        }

        public void Execute()
        {
            WordBreak("aaaaaaaaaaaaaaa", new[] {"aaaa", "aa", "aaa"});
            WordBreak("leetcodere", new[] {"leet", "co", "d", "e", "re"});
        }
    }
}