using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode.Algorithm
{
    class ReorganizeStringSln : ISolution
    {
        public string ReorganizeString(string S)
        {
            List<Tuple<char, int>> tuples = new List<Tuple<char, int>>();
            for (int i = 0; i < 26; i++)
            {
                tuples.Add(new Tuple<char, int>((char) ('a' + i), S.Count(s => s == (char) ('a' + i))));
            }

            StringBuilder sb = new StringBuilder();
            tuples = tuples.OrderByDescending(t => t.Item2).ToList();
            char prev = 'X';
            for (int i = 0; i < S.Length; i++)
            {
                tuples = tuples.OrderByDescending(t => t.Item2).ToList();
                var first = tuples[0];
                var second = tuples[1];
                if (first.Item1 == prev)
                {
                    if (second.Item2 == 0)
                    {
                        return string.Empty;
                    }

                    sb.Append(second.Item1);
                    prev = second.Item1;
                    tuples[1] = new Tuple<char, int>(second.Item1, second.Item2 - 1);
                }
                else
                {
                    sb.Append(first.Item1);
                    prev = first.Item1;
                    tuples[0] = new Tuple<char, int>(first.Item1, first.Item2 - 1);
                }
            }

            return sb.ToString();
        }

        public void Execute()
        {
            throw new NotImplementedException();
        }
    }
}