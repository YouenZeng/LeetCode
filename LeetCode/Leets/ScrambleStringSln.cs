using System;

namespace LeetCode.Leets
{
    public class ScrambleStringSln : ISolution
    {
        public bool IsScramble(string s1, string s2)
        {
            if (s1 == s2)
                return true;

            int lengh = s1.Length;
            int[] count = new int[26];


            for (int i = 0; i < lengh; i++)
            {
                count[s1[i] - 'a']++;
                count[s2[i] - 'a']--;
            }

            for (int i = 0; i < 26; i++)
            {
                if (count[i] != 0)
                    return false;
            }

            for (int i = 1; i <= lengh - 1; i++)
            {
                if (IsScramble(s1.Substring(0, i), s2.Substring(0, i)) && IsScramble(s1.Substring(i), s2.Substring(i)))
                    return true;
                if (IsScramble(s1.Substring(0, i), s2.Substring(lengh - i)) && IsScramble(s1.Substring(i), s2.Substring(0, lengh - i)))
                    return true;
            }
            return false;
        }
        public void Execute()
        {
            Console.WriteLine(IsScramble("great", "retag"));
        }
    }
}
