using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.LeetAgain
{
    class GroupAnagramsSln : ISolution
    {
        public IList<IList<string>> GroupAnagrams(string[] strs)
        {
            Dictionary<string, List<string>> dict = new Dictionary<string, List<string>>();

            int[] charHash = new int[26];
            for (int i = 0; i < 26; i++)
            {
                charHash[i] = 1 << i;
            }

            for (int i = 0; i < strs.Length; i++)
            {
                var hash = HashString(strs[i], charHash);
                if (!dict.ContainsKey(hash))
                {
                    dict.Add(hash, new List<string>()
                    {
                        strs[i]
                    });
                }
                else
                {
                    dict[hash].Add(strs[i]);
                }
            }

            IList<IList<string>> result = new List<IList<string>>();

            foreach (KeyValuePair<string, List<string>> keyValuePair in dict)
            {
                result.Add(keyValuePair.Value);
            }

            return result;
        }



        private string HashString(string str, int[] charHash)
        {
            if (string.IsNullOrEmpty(str))
                return string.Empty;
            int currentHash = charHash[str[0] - 'a'];
            int xorHash = charHash[str[0] - 'a'];
            for (int j = 1; j < str.Length; j++)
            {
                currentHash = currentHash + charHash[str[j] - 'a'];
                xorHash = xorHash ^ charHash[str[j] - 'a'];
            }

            return currentHash + "-" + xorHash + "-" + str.Length;
        }

        public void Execute()
        {
            GroupAnagrams(new[] { "huh", "tit" });
        }
    }
}