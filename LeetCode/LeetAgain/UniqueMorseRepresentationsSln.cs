using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.LeetAgain
{
    class UniqueMorseRepresentationsSln : ISolution
    {
        public int UniqueMorseRepresentations(string[] words)
        {
            string[] charMorse = {
                ".-", "-...", "-.-.", "-..", ".", "..-.", "--.", "....", "..", ".---", "-.-", ".-..", "--", "-.", "---",
                ".--.", "--.-", ".-.", "...", "-", "..-", "...-", ".--", "-..-", "-.--", "--.."
            };

            Dictionary<string, int> dict = new Dictionary<string, int>();
            int max = 0;
            foreach (string word in words)
            {
                string combined = string.Empty;

                foreach (char c in word)
                {
                    combined += charMorse[c - 'a'];
                }

                if (dict.ContainsKey(combined))
                {
                    dict[combined]++;
                }
                else
                {
                    dict.Add(combined, 1);
                    max++;
                }

               
            }

            return max;
        }

        public void Execute()
        {
            throw new NotImplementedException();
        }
    }
}