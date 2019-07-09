using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.LeetAgain
{
    class CountAndSaySln : ISolution
    {
        public string CountAndSay(int n)
        {
            //1 = One 1 , 11

            int start = 1;
            List<char> t = new List<char> {'1'};
            while (start < n)
            {
                int count = 1;
                char first = t[0];
                List<char> newList = new List<char>();
                for (int i = 1; i < t.Count; i++)
                {
                    if (t[i] == first)
                    {
                        count++;
                    }
                    else
                    {
                        newList.Add((char) (0x30 + count));
                        newList.Add(first);

                        count = 1;
                        first = t[i];
                    }
                }

                newList.Add((char) (0x30 + count));
                newList.Add(first);

                t = newList;
                start++;
            }

            return string.Join("", t);
        }

        public void Execute()
        {
            Console.WriteLine(CountAndSay(1));
            Console.WriteLine(CountAndSay(2));
            Console.WriteLine(CountAndSay(3));
            Console.WriteLine(CountAndSay(4));
            Console.WriteLine(CountAndSay(5));
            Console.WriteLine(CountAndSay(6));
            ;
        }
    }
}