using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Leets
{
    class LetterCountSln : ISolution
    {
        public string LetterCount(string input)
        {
            var wordArr = input.Split(' ').ToList();
            var dict = new Dictionary<string,int>();
            foreach (string s in wordArr)
            {
                int max = 0;
                var dictChar = new Dictionary<char, int>();
                foreach (char c in s)
                {
                    if (dictChar.ContainsKey(c)== false)
                        dictChar.Add(c,1);
                    else
                    {
                        dictChar[c] = dictChar[c] + 1;
                    }
                }
                foreach (KeyValuePair<char, int> pair in dictChar)
                {
                    if (pair.Value > max)
                        max = pair.Value;
                }
                dict.Add(s,max);
            }

            int result = 0;
            string str = string.Empty;
            foreach (KeyValuePair<string, int> pair in dict)
            {
                if (pair.Value > result)
                {
                    result = pair.Value;
                    str = pair.Key;
                }
            }
            return str;
        }
        public void Execute()
        {
            var testInput = "aa abababab banana cccc";
            var result = LetterCount(testInput);
            Console.WriteLine(result);
        }
    }
}
