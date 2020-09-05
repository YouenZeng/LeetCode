using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.LeetAgain
{
    class MinWindowSln : ISolution
    {
        public string MinWindow(string s, string t)
        {
            int[] m = new int[128];

            foreach (var t1 in t)
            {
                m[t1] += 1;
            }

            int start = 0;
            int end = 0;
            int counter = t.Length;
            int minStart = 0;
            int minLen = int.MaxValue;

            while (end < s.Length)
            {
                if (m[s[end]] > 0)
                {
                    counter--;
                }

                m[s[end]]--;
                end++;

                while (counter == 0)
                {
                    if (end - start < minLen)
                    {
                        minStart = start;
                        minLen = end - start;
                    }

                   
                    m[s[start]]++;
                    //start的索引一定被扫描过了, 如果T不需要这些,则数组会标记为负值,++后肯定是小于等于0的
                    //如果++后, m[s[start]] >0 ,意味着我们要找到一个这样的字母, 所以要把count++
                    //如果找不到的话, 那就..结束了
                    if (m[s[start]] > 0)
                    {
                        counter++;
                    }

                    start++;
                }
            }

            return minLen == int.MaxValue ? string.Empty : s.Substring(minStart, minLen);
        }

        public void Execute()
        {
            Console.WriteLine(MinWindow("BADOBECODEBANBC", "ADB"));
        }
    }
}