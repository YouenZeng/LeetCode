using System;
using System.Collections.Generic;
using System.Text;
using LeetCode.LeetAgain;

namespace LeetCode.Challenge
{
    class RemoveDuplicatesssLSln : ISolution
    {
        public string RemoveDuplicates(string S)
        {
            LinkedList<char> list = new LinkedList<char>();
            foreach (char c in S)
            {
                
                if (list.Count == 0 || list.Last.Value != c)
                {
                    list.AddLast(c);
                }
                else
                {
                    list.RemoveLast();
                }
            }

            StringBuilder sb = new StringBuilder();
            while (list.Count > 0)
            {
                sb.Append(list.First.Value);
                list.RemoveFirst();
            }

            return sb.ToString();
        }

        public void Execute()
        {
            throw new NotImplementedException();
        }
    }
}