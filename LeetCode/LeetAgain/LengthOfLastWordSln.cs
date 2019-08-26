using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.LeetAgain
{
    class LengthOfLastWordSln : ISolution
    {
        public int LengthOfLastWord(string s)
        {
            if (string.IsNullOrEmpty(s))
                return 0;

            s = " " + s + " ";

            int start = s.Length - 1;
            while (start > 0)
            {
                if (s[start] != ' ')
                {
                    break;
                }
                start--;
            }

            int spaceFirstSeen = 0;
            for (int i = 0; i < start; i++)
            {
                if (s[i] == ' ')
                {
                    spaceFirstSeen = i;
                }
            }

            return start - spaceFirstSeen;
        }
        public void Execute()
        {
            LengthOfLastWord("hello world");
            LengthOfLastWord(" a ");
            LengthOfLastWord("a");
            LengthOfLastWord(" ");
        }
    }
}
