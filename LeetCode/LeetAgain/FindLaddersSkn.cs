using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace LeetCode.LeetAgain
{
    public class FindLaddersSln : ISolution
    {
        /// <summary>
        /// 126
        /// </summary>
        /// <param name="beginWord"></param>
        /// <param name="endWord"></param>
        /// <param name="wordList"></param>
        /// <returns></returns>
        public IList<IList<string>> FindLadders(string beginWord, string endWord, IList<string> wordList)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// 127
        /// </summary>
        /// <param name="beginWord"></param>
        /// <param name="endWord"></param>
        /// <param name="wordList"></param>
        /// <returns></returns>
        public int LadderLength(string beginWord, string endWord, IList<string> wordList)
        {
            HashSet<string> words = new HashSet<string>(wordList);
            HashSet<string> visisted = new HashSet<string>();
            Queue<string> q = new Queue<string>();
            q.Enqueue(beginWord);
            int wordLength = beginWord.Length;

            int ladder = 1;
            while (q.Count > 0)
            {
                for (int k = q.Count; k > 0; k--)
                {
                    var w = q.Dequeue();
                    if (w == endWord)
                    {
                        return ladder;
                    }

                    for (int i = 0; i < wordLength; i++)
                    {
                        var wordChar = w.ToCharArray();

                        for (int j = 0; j < 26; j++)
                        {
                            if ((char) ('a' + j) == w[i]) continue;

                            wordChar[i] = (char) ('a' + j);
                            var transform = new string(wordChar);


                            if (words.Contains(transform) && visisted.Add(transform))
                            {
                                q.Enqueue(transform);
                            }
                        }
                    }
                }

                ladder++;
            }


            return 0;
        }

        public int LadderLength2(string beginWord, string endWord, IList<string> wordList)
        {
            HashSet<string> words = new HashSet<string>(wordList);
            if (!words.Contains(endWord)) return 0;

            HashSet<string> beginSet = new HashSet<string>();
            HashSet<string> endSet = new HashSet<string>();
            HashSet<string> visisted = new HashSet<string>();

            beginSet.Add(beginWord);
            endSet.Add(endWord);
            visisted.Add(beginWord);
            visisted.Add(endWord);

            int ladder = 1;
            while (beginSet.Count > 0 && endSet.Count > 0)
            {
                bool ls = beginSet.Count > endSet.Count;
                HashSet<string> small = ls ? endSet : beginSet;
                HashSet<string> large = ls ? beginSet : endSet;
                HashSet<string> next = new HashSet<string>();
                ladder++;

                foreach (string s in small)
                {
                    for (int i = 0; i < s.Length; i++)
                    {
                        var wArray = s.ToCharArray();
                        for (char c = 'a'; c <= 'z'; c++)
                        {
                            wArray[i] = c;
                            string w = new string(wArray);

                            if (large.Contains(w))
                                return ladder;

                            if (words.Contains(w) && visisted.Add(w))
                            {
                                next.Add(w);
                            }
                        }
                    }
                }

                if (ls)
                    endSet = next;
                else
                {
                    beginSet = next;
                }
            }

            return 0;
        }


        public void Execute()
        {
            var a = LadderLength2("hit", "cog", new List<string>()
            {
                //"hog",
                "hot",
                "dot",
                "dog",
                "lot",
                "log",
                //"cog"
            });
            Console.WriteLine(a);
        }
    }
}