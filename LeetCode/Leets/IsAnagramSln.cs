using System;

namespace LeetCode.Leets
{
    class IsAnagramSln : ISolution
    {
        public bool IsAnagram(string s, string t)
        {
            int[] all = new int[26];
            foreach (char c in s)
            {
                all[Char.ToUpper(c) - 65]++;
            }
            foreach (char c in t)
            {
                all[Char.ToUpper(c) - 65]--;
            }
            foreach (int item in all)
            {
                if (item != 0) return false;
            }
            return true;
        }
        public void Execute()
        {
            Console.WriteLine(IsAnagram("zlap", "kcqx"));
        }
    }
}
