using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace LeetCode.Leets
{
    public class WordLadderSolution : ISolution
    {
        public int LadderLength(string start, string end, ISet<string> dict)
        {
            var queue = new Queue<string>();
            queue.Enqueue(start);
            dict.Add(end);
            int step = 0;
            while (queue.Count != 0)
            {
                var level = new Queue<string>();
                step++;
                while (queue.Count != 0)
                {
                    String q = queue.Dequeue();
                    if (q.Equals(end))
                        return step;
                    for (int i = 0; i < start.Length; i++)
                    {
                        for (char c = 'a'; c <= 'z'; c++)
                        {
                            String s = q.Substring(0, i) + c + q.Substring(i + 1, start.Length - 1 - i);
                            if (dict.Contains(s))
                            {
                                level.Enqueue(s);
                                dict.Remove(s);
                            }
                        }
                    }
                }
                queue = level;
            }
            return 0;
        }

        private readonly IList<string> _stepList = new List<string>();
        //public int LadderLength(string beginWord, string endWord, ISet<string> wordDict)
        //{
        //    string currentWord = FindLike(beginWord, wordDict, endWord);
        //    if (currentWord == null && _stepList.Count>1)
        //    {
        //        Console.WriteLine("Find failed.. " + beginWord + ", now step back");

        //        wordDict.Remove(beginWord);
        //        _stepList.Remove(beginWord);
        //        currentWord = _stepList[_stepList.Count - 1];
        //    }
        //    if (currentWord != null && currentWord != endWord)
        //    {
        //        Console.WriteLine(beginWord + " --> " + currentWord);
        //        _stepList.Add(currentWord);
        //    }
        //    if (currentWord == endWord)
        //    {
        //        return 0;
        //    }
        //    if (currentWord == null)
        //    {
        //        return 0;
        //    }
        //    return LadderLength(currentWord, endWord, wordDict) + 1;

        //}

        private string FindLike(string word, ISet<string> wordDict, string endWord)
        {
            char[] c = word.ToCharArray();

            var cc = c.Count(t => endWord.IndexOf(t) > -1);
            if (cc == c.Length - 1)
            {
                return endWord;
            }

            foreach (string s in wordDict)
            {
                if (_stepList.Contains(s))
                {
                    continue;
                }
                int count = 0;
                for (int i = 0; i < c.Length; i++)
                {
                    if (s.IndexOf(c[i]) > -1)
                        count++;
                }

                if (count == c.Length - 1)
                {
                    return s;
                }
            }
            return null;
        }
        public void Execute()
        {
            ISet<string> test = new HashSet<string>(new[] { "hot", "dot", "dog", "lot", "log" });
            const string beginWord = "hit";
            const string endWord = "cog";

            Console.WriteLine(LadderLength(beginWord, endWord, test));

            //for (char c = 'a'; c <= 'z'; c++)
            //{
            //    Console.WriteLine(c);
            //}
        }
    }
}
