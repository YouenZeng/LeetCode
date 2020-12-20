using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Challenge
{
    class UniqueMorseRepresentationsSln : ISolution
    {
        public int UniqueMorseRepresentations(string[] words)
        {
            string[] morseDict = new string[26] { ".-", "-...", "-.-.", "-..", ".", "..-.", "--.", "....", "..", ".---", "-.-", ".-..", "--", "-.", "---", ".--.", "--.-", ".-.", "...", "-", "..-", "...-", ".--", "-..-", "-.--", "--.." };

            HashSet<string> hs = new HashSet<string>();

            foreach (var item in words)
            {
                var sb = new StringBuilder();
                foreach (var c in item)
                {
                    sb.Append(morseDict[c - 'a']);
                }

                hs.Add(sb.ToString());
            }

            return hs.Count;

        }
        public void Execute()
        {
            throw new NotImplementedException();
        }
    }
}
