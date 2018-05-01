using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.LeetAgain
{
    internal class DetectCapitalUseSln : ISolution
    {
        public bool DetectCapitalUse(string word)
        {
            var allLower = true;
            for (var i = 1; i < word.Length; i++) allLower &= word[i] >= 97;

            var allUpper = true;
            if (word[0] < 97)
            {
                for (var i = 1; i < word.Length; i++) allUpper &= word[i] < 97;
                return allUpper || allLower;
            }

            return allLower;
        }

        public void Execute()
        {
            throw new NotImplementedException();
        }
    }
}