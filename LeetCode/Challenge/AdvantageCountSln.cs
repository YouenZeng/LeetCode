using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode.Challenge
{
    class AdvantageCountSln : ISolution
    {
        public int[] AdvantageCount2(int[] A, int[] B)
        {
            List<Tuple<int, int>> tuples = B
                .Select((element, index) => new Tuple<int, int>(element, index))
                .OrderByDescending(tuple => tuple.Item1).ToList();
            Array.Sort(A);
            int left = 0;
            int right = A.Length - 1;
            foreach (Tuple<int, int> pair in tuples)
            {
                B[pair.Item2] = pair.Item1 >= A[right] ? A[left++] : A[right--];
            }

            return B;
        }


        public int[] AdvantageCount(int[] A, int[] B)
        {
            int[] aCopy = new int[A.Length];
            Array.Copy(A, aCopy, A.Length);
            Array.Sort(aCopy);
            int[] bCopy = new int[B.Length];
            Array.Copy(B, bCopy, B.Length);
            Array.Sort(bCopy);
            Dictionary<int, List<int>> dict = new Dictionary<int, List<int>>();
            List<int> others = new List<int>();

            int bIdx = 0;
            foreach (int a in aCopy)
            {
                if (a > bCopy[bIdx])
                {
                    if (dict.ContainsKey(bCopy[bIdx]))
                    {
                        dict[bCopy[bIdx]].Add(a);
                    }
                    else
                    {
                        dict[bCopy[bIdx]] = new List<int>() {a};
                    }

                    bIdx++;
                }
                else
                {
                    others.Add(a);
                }
            }

            int[] result = new int[B.Length];

            for (int i = 0; i < B.Length; i++)
            {
                if (dict.ContainsKey(B[i]) && dict[B[i]].Count > 0)
                {
                    result[i] = dict[B[i]].First();
                    dict[B[i]].RemoveAt(0);
                }
                else
                {
                    result[i] = others.First();
                    others.RemoveAt(0);
                }
            }

            return result;
        }

        public void Execute()
        {
            AdvantageCount2(new int[] {2, 7, 11, 15}, new int[] {1, 10, 4, 11});
        }
    }
}