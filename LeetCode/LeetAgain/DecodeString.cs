using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.LeetAgain
{
    public class DecodeStringSln : ISolution
    {
        public string DecodeString(string s)
        {
            StringBuilder sb = new StringBuilder();

            Stack<string> decodeStack = new Stack<string>();
            string stringTrace = string.Empty;
            for (int i = 0; i < s.Length; i++)
            {
                if (Char.IsDigit(s[i]))
                {
                    if (string.IsNullOrEmpty(stringTrace) == false)
                    {
                        decodeStack.Push(stringTrace);
                        stringTrace = string.Empty;
                    }
                    stringTrace += s[i];
                }

                if (Char.IsLetter(s[i]))
                {
                    stringTrace += s[i];
                }

                if (s[i] == '[' || s[i] == ']')
                {
                    if (string.IsNullOrEmpty(stringTrace) == false)
                    {
                        decodeStack.Push(stringTrace);
                        stringTrace = string.Empty;
                    }
                    decodeStack.Push(s[i].ToString());
                }
            }

            throw new NotImplementedException();

            return sb.ToString();
        }
        public void Execute()
        {
            // DecodeString("3[a]2[bc]");
            DecodeString("3[a2[c]]");
            DecodeString("32[abc]3[cd]ef");
        }
    }
}
