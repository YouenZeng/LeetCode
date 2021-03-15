using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Challenge
{
    class FindLaddersSln : ISolution
    {
        public IList<IList<string>> FindLadders(string beginWord, string endWord, IList<string> wordList)
        {
            HashSet<string> hs = new HashSet<string>(wordList);
            if (!hs.Contains(beginWord) || !hs.Contains(endWord))
            {
                return null;
            }

            Queue<string> q = new Queue<string>();
            HashSet<string> visited = new HashSet<string>();
            q.Enqueue(beginWord);
            visited.Add(beginWord);
            while (q.Count > 0)
            {
                string w = q.Dequeue();
                visited.Add(w);
                for (int i = 0; i < w.Length; i++)
                {
                    char[] arr = w.ToCharArray();
                    for (int j = 0; j < 26; j++)
                    {
                        arr[i] = (char) ('a' + j);
                        string s = new string(arr);
                        if (hs.Contains(s) && !visited.Contains(s))
                        {
                            q.Enqueue(s);
                        }
                    }
                }
            }

            throw new NotImplementedException();
        }

        public void Execute()
        {
            throw new NotImplementedException();
        }
    }
}