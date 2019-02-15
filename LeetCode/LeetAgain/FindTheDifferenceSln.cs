using System;

namespace LeetCode.LeetAgain
{
    internal class FindTheDifferenceSln : ISolution
    {
        public char FindTheDifference(string s, string t)
        {
            int temp = t[s.Length - 1];
            for (int i = 0; i < s.Length; i++)
            {
                temp = temp ^ s[i] ^ t[i];
            }

            return (char)temp;
        }
        public void Execute()
        {
            throw new NotImplementedException();
        }
    }
}
