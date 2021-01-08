using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode.Challenge
{
    class LongestStringSln : ISolution
    {
        private char lastLetter = ' ';
        private char nextToLastLetter = ' ';

        //public string solution(int A, int B, int C)
        //{
        //    // write your code in C# 6.0 with .NET 4.5 (Mono)            
        //    Dictionary<char, int> dictionary = new Dictionary<char, int>() { { 'a', A }, { 'b', B }, { 'c', C } };

        //    lastLetter = ' ';
        //    nextToLastLetter = ' ';
        //    string stringCombination = "";

        //    while (dictionary['a'] > 0 || dictionary['b'] > 0 || dictionary['c'] > 0)
        //    {
        //        var list = dictionary.Where(c => c.Key != lastLetter && c.Value > 0).OrderBy(c => c.Value).FirstOrDefault();



        //        var temp = stringCombination;
        //        int tempL = temp.Length;
        //        var resultA = PickNextTwoLetters(dictionary, list[2].Key, ref temp);

        //        if (tempL == temp.Length)
        //        {
        //            break;
        //        }
        //        stringCombination = temp;
        //    }

        //    return stringCombination;
        //}
        //private bool PickNextLetter(Dictionary<char, int> dic, char letter, ref string stringCombination)
        //{
        //    if (dic[letter] <= 0) return false;
        //    if (lastLetter == nextToLastLetter && nextToLastLetter == letter) return false;

        //    stringCombination += letter;
        //    dic[letter]--;

        //    nextToLastLetter = lastLetter;
        //    lastLetter = letter;
        //    return true;
        //}

        //private bool PickNextTwoLetters(Dictionary<char, int> dic, char letter, ref string stringCombination)
        //{
        //    var leftLetterCount = dic[letter];
        //    if (leftLetterCount <= 0) return false;
        //    if (leftLetterCount == 1) return PickNextLetter(dic, letter, ref stringCombination);
        //    if (PickNextLetter(dic, letter, ref stringCombination) == false) return false;
        //    return PickNextLetter(dic, letter, ref stringCombination);
        //}

        public string LongestString(int a, int b, int c)
        {
            Dictionary<char, int> dict = new Dictionary<char, int>();
            dict['a'] = a;
            dict['b'] = b;
            dict['c'] = c;

            var list = dict.Select(x => new int[] { (int)x.Key, x.Value }).ToList();
            list.Sort((x, y) => -x[1].CompareTo(y[1]));

            var sb = new StringBuilder();

            int prevChar = -1;
            while (list[0][1] > 0)
            {
                int sbLength = sb.Length;

                for (int i = 0; i < list.Count; i++)
                {
                    var item = list[i];
                    if (item[1] > 0 && prevChar != item[0])
                    {
                        if (item[1] >= 2 && i == 0)
                        {
                            item[1] -= 2;
                            sb.Append((char)(item[0]));
                            sb.Append((char)(item[0]));
                        }
                        else
                        {
                            item[1] -= 1;
                            sb.Append((char)(item[0]));
                        }
                        prevChar = (char)(item[0]);
                        break;
                    }
                }

                if (sb.Length == sbLength)
                {
                    break;
                }
                list.Sort((x, y) => -x[1].CompareTo(y[1]));
            }


            return sb.ToString();
        }


        public void Execute()
        {
            LongestString(3, 2, 22);
            //solution(4, 4, 4);
            //solution(1, 1, 1);
            //solution(0, 0, 6);
        }
    }
}
