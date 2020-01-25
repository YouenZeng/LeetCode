using System;
using System.Collections.Generic;

namespace LeetCode.LeetAgain
{
    class GetPermutationSln : ISolution
    {
        public string GetPermutation(int n, int k)
        {
            string result = string.Empty;
            List<char> charList = new List<char>();
            int max = 1;
            for (int i = 1; i <= n; i++)
            {
                charList.Add((char)(i + 0x30));
                max = max * i;
            }
            int current = k;
            int seed = n;
            var areaSize = max;
            while (seed > 0)
            {
                areaSize = areaSize / seed;
                //area
                int charArea = (current - 1) / areaSize;
                current -= charArea * areaSize;

                seed--;
                result += charList[charArea];
                charList.RemoveAt(charArea);
            }

            return result;
        }
        public void Execute()
        {
            GetPermutation(3, 3);
            GetPermutation(4, 9);
        }
    }
}
