using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Challenge
{
    class DeckRevealedIncreasingSln : ISolution
    {
        public int[] DeckRevealedIncreasing(int[] deck)
        {
            LinkedList<int> link = new LinkedList<int>();
            int deckCount = deck.Length;

            for (int i = 0; i < deckCount; i++)
            {
                link.AddLast(i);
            }

            int[] visit = new int[deckCount];
            int visitIndex = 0;
            while (link.Count > 0)
            {
                visit[visitIndex] = link.First.Value;
                visitIndex++;
                link.RemoveFirst();
                if (link.Count > 0)
                {
                    link.AddLast(link.First.Value);
                    link.RemoveFirst();
                }
            }

            Array.Sort(deck);
            int[] result = new int[deckCount];
            for (int i = 0; i < deckCount; i++)
            {
                result[visit[i]] = deck[i];
            }

            return result;
        }

        public void Execute()
        {
            DeckRevealedIncreasing(new int[] { 17, 13, 11, 2, 3, 5, 7 });
        }
    }
}