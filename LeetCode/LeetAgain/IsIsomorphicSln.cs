using System;
using System.Collections.Generic;

namespace LeetCode.LeetAgain
{
    public class IsIsomorphicSln : ISolution
    {
        public bool IsIsomorphic(string s, string t)
        {
            var dictMap = new Dictionary<char, char>();
            int length = s.Length;
            for (int i = 0; i < length; i++)
            {
                if (dictMap.ContainsKey(s[i]) == false)
                {
                    if (dictMap.ContainsValue(t[i]))
                        return false;

                    dictMap.Add(s[i], t[i]);
                }
                else
                {
                    if (dictMap[s[i]] != t[i])
                    {
                        return false;
                    }
                }
            }

            return true;
        }
        void ISolution.Execute()
        {
            throw new NotImplementedException();
        }
    }
}