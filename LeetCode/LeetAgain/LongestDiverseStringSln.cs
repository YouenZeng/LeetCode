using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode.LeetAgain
{
    class LongestDiverseStringSln : ISolution
    {
        public string LongestDiverseString(int a, int b, int c)
        {
            //greedy
            List<Tuple<char, int>> t = new List<Tuple<char, int>>
            {
                new Tuple<char, int>('a', a), new Tuple<char, int>('b', b), new Tuple<char, int>('c', c)
            };

            StringBuilder sb = new StringBuilder();

            char prevChar = 'x';
            while (true)
            {
                t = t.OrderByDescending(d => d.Item2).ToList();

                int itemIndex = t[0].Item1 != prevChar ? 0 : 1;
                var item = t[0].Item1 != prevChar ? t[0] : t[1];
                t.Remove(item);
                if (item.Item2 == 0)
                {
                    break;
                }

                prevChar = item.Item1;
                if (item.Item2 > 2 && itemIndex == 0)
                {
                    sb.Append(item.Item1);
                    sb.Append(item.Item1);
                    t.Add(new Tuple<char, int>(item.Item1, item.Item2 - 2));
                }
                else
                {
                    sb.Append(item.Item1);
                    t.Add(new Tuple<char, int>(item.Item1, item.Item2 - 1));
                }
            }

            return sb.ToString();
        }


        public void Execute()
        {
            Console.WriteLine(LongestDiverseString(1, 1, 7));

            ;
        }
    }
}