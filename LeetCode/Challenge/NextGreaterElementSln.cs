using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Challenge
{
    class NextGreaterElementSln : ISolution
    {
        public int NextGreaterElement(int n)
        {
            //9 2 5321
            char[] s = n.ToString().ToCharArray();

            int i = s.Length - 2;
            char prev = s[s.Length - 1];
            for (; i >= 0; i--)
            {
                if (s[i] >= prev)
                {
                    prev = s[i];
                }
                else
                {
                    break;
                }
            }
            if (i < 0) { return -1; }
            //2 5 [3] 21
            //12235
            //3 1225
            int charToReplace = s[i] - '0';
            int targetIndex = -1;
            for (int j = charToReplace + 1; j < 10 && targetIndex == -1; j++)
            {
                for (int k = i + 1; k <= s.Length - 1; k++)
                {
                    if (s[k] - '0' == j)
                    {
                        targetIndex = k;
                        break;
                    }
                }
            }

            char temp = s[i];
            s[i] = s[targetIndex];
            s[targetIndex] = temp;

            Array.Sort(s, i + 1, s.Length - 1 - i);
            var r = string.Join("", s);
            var r1 = Convert.ToInt64(r);
            if (r1 > Int32.MaxValue) return -1;
            return (int)r1;

        }
        public void Execute()
        {
            NextGreaterElement(1999999999);
            NextGreaterElement(12);
            NextGreaterElement(21);
        }
    }
}
