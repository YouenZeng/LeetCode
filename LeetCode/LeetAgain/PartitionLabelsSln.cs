using System;
using System.Collections.Generic;

namespace LeetCode.LeetAgain
{
    class PartitionLabelsSln : ISolution
    {
        public IList<int> PartitionLabels(string S)
        {
            Dictionary<char, int> lastIndexDict = new Dictionary<char, int>();

            for (int i = 0; i < S.Length; i++)
            {
                if (lastIndexDict.ContainsKey(S[i]))
                {
                    lastIndexDict[S[i]] = i;
                }
                else
                {
                    lastIndexDict.Add(S[i], i);
                }
            }
            List<int> result = new List<int>();
            for (int i = 0; i < S.Length; i++)
            {
                if (lastIndexDict[S[i]] == i)
                {
                    result.Add(1);
                    continue;
                }
                int lastIndex = lastIndexDict[S[i]];
                int loopStart = i;
                while (loopStart < lastIndex)
                {
                    lastIndex = Math.Max(lastIndex, lastIndexDict[S[loopStart]]);
                    loopStart++;
                }

                result.Add(lastIndex - i + 1);
                i = lastIndex;
            }


            return result;
        }
        public void Execute()
        {
            PartitionLabels("qiejxqfnqceocmy");
        }
    }
}
