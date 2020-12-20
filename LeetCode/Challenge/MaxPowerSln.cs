using System;

namespace LeetCode.Challenge
{
    class MaxPowerSln : ISolution
    {
        public int MaxPower(string s)
        {
            if (string.IsNullOrEmpty(s))
            {
                return 0;
            }
            int currentMax = 0;
            int count = 1;
            int start = 1;
            int end = s.Length - 1;
            char prevChar = s[0];

            while (start <= end)
            {
                if (s[start] != prevChar)
                {
                    prevChar = s[start];
                    currentMax = Math.Max(currentMax, count);
                    count = 0;
                }

                count++;
                start++;
            }
            currentMax = Math.Max(currentMax, count);

            return currentMax;
        }

        public void Execute()
        {
            MaxPower("triplepillooooo");
            MaxPower("");
            
            MaxPower("raaaaazer");
        }
    }
}