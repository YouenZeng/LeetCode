using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Challenge
{
    class FindItinerarySln : ISolution
    {
        public IList<string> FindItinerary(IList<IList<string>> tickets)
        {
            //from JFK
            //all tickets must be used

            //DFS

            Dictionary<string, SortedDictionary<string,int>> adjs = new Dictionary<string, SortedDictionary<string, int>>();
            foreach (var t in tickets)
            {
                if(!adjs.ContainsKey(t[0]))
                {
                    adjs[t[0]] = new SortedDictionary<string, int>(
                        Comparer<string>.Create( (s1,s2)=> { return s2.CompareTo(s1); })
                        );
                }

                if (adjs[t[0]].ContainsKey(t[1]))
                {
                    adjs[t[0]][t[1]]++;
                }
                else
                {
                    adjs[t[0]][t[1]] = 1;
                }
            }

            Stack<string> stack = new Stack<string>();
            stack.Push("JFK");
            List<string> result = new List<string>();
            while(stack.Count > 0)
            {
                var current = stack.Pop();
                result.Add(current);
                if (!adjs.ContainsKey(current))
                {
                    continue;
                }
                var destination = adjs[current];
                List<string> dUsed = new List<string>();
                foreach (var kvp in destination)
                {
                    if(kvp.Value > 0)
                    {
                        stack.Push(kvp.Key);
                        dUsed.Add(kvp.Key);
                    }
                }

                foreach (var u in dUsed)
                {
                    destination[u]--;
                }

            }
            return result;

        }
        public void Execute()
        {
            var tickets = new List<IList<string>>();
            tickets.Add(new List<string>() { "JFK", "SFO" });
            tickets.Add(new List<string>() { "JFK", "ATL" });
            tickets.Add(new List<string>() { "SFO", "ATL" });
            tickets.Add(new List<string>() { "ATL", "JFK" });
            tickets.Add(new List<string>() { "ATL", "SFO" });
            FindItinerary(tickets);
        }
    }
}
