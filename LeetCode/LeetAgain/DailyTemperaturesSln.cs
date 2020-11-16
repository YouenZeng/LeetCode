using System;
using System.Collections.Generic;

namespace LeetCode.LeetAgain
{
    public class DailyTemperaturesSln : ISolution
    {
        public int[] DailyTemperatures(int[] T)
        {
            int[] result = new int[T.Length];

            for (int i = T.Length - 1; i >= 0; i--)
            {
                int j = i + 1;
                while (j < T.Length)
                {
                    if (T[j] > T[i])
                    {
                        result[i] = j - i;
                        break;
                    }

                    if (result[j] == 0)
                    {
                        break;
                    }

                    j += result[j];
                }
            }

            return result;
        }

        public int[] DailyTemperatures2(int[] T)
        {
            Stack<int> stack = new Stack<int>();
            int[] ret = new int[T.Length];
            for (int i = 0; i < T.Length; i++)
            {
                while (stack.Count > 0 && T[i] > T[stack.Peek()])
                {
                    int idx = stack.Pop();
                    ret[idx] = i - idx;
                }

                stack.Push(i);
            }

            return ret;
        }

        public void Execute()
        {
            DailyTemperatures2(new int[] {73, 74, 75, 71, 69, 72, 76, 73});
        }
    }
}