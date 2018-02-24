
using System;
public class ZigZag
{

    public int longestZigZag(int[] sequence)
    {
        int prevPostive = 1;
        int prevNegative = 1;

        for (int i = 1; i < sequence.Length; i++)
        {
            if (sequence[i] > sequence[i - 1])
            {
                prevNegative = prevPostive + 1;
            }
            if (sequence[i] < sequence[i - 1])
            {
                prevPostive = prevNegative + 1;
            }
        }

        return Math.Max(prevPostive, prevNegative);
    }
}
