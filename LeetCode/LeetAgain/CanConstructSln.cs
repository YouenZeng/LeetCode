using System;

namespace LeetCode.LeetAgain
{
    class CanConstructSln : ISolution
    {
        public bool CanConstruct(string ransomNote, string magazine)
        {
            if(string.IsNullOrEmpty(ransomNote))
            {
                return true;
            }
            if (string.IsNullOrEmpty(magazine))
            {
                return false;
            }
            int[] magazineStat = new int[26];

            for (int i = 0; i < magazine.Length; i++)
            {
                magazineStat[magazine[i] - 'a']++;
            }

            for (int i = 0; i < ransomNote.Length; i++)
            {
                magazineStat[ransomNote[i] - 'a']--;
                if (magazineStat[ransomNote[i] - 'a'] < 0)
                {
                    return false;
                }
            }

            return true;

        }
        public void Execute()
        {
            throw new NotImplementedException();
        }
    }
}
