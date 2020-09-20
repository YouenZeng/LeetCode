using System;

namespace LeetCode.LeetAgain
{
    public class IsScrambleSln : ISolution
    {
        public bool IsScramble(string s1, string s2)
        {
            if (s1 == s2)
                return true;

            int[] cache = new int[26];

            for (int i = 0; i < s1.Length; i++)
            {
                cache[s1[i] - 0x61]++;
                cache[s2[i] - 0x61]--;
            }

            for (int i = 0; i < 26; i++)
            {
                if (cache[i] != 0)
                    return false;
            }


            for (int i = 1; i < s1.Length; i++)
            {
                //not swap
                if (IsScramble(s1.Substring(i, s1.Length - i), s2.Substring(i, s2.Length - i))
                    && IsScramble(s1.Substring(0, i), s2.Substring(0, i)))
                {
                    return true;
                }

                //swap
                if (IsScramble(s1.Substring(i, s1.Length - i), s2.Substring(0, s1.Length - i))
                    && IsScramble(s1.Substring(0, i), s2.Substring(s2.Length - i, i)))
                {
                    return true;
                }
            }

            return false;
        }

        public void Execute()
        {
            IsScramble("abcde", "caebd");
        }
    }
}