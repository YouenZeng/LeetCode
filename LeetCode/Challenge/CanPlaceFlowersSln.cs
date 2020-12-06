using System;

namespace LeetCode.Challenge
{
    class CanPlaceFlowersSln : ISolution
    {
        public bool CanPlaceFlowers(int[] flowerbed, int n)
        {
            if (flowerbed.Length == 1)
            {
                return n == 1 ? flowerbed[0] == 0 : true;
            }

            int canPlaceCount = 0;
            int zeroCount = 0;
            for (int i = 0; i < flowerbed.Length; i++)
            {
                if (flowerbed[i] == 0)
                {
                    zeroCount++;
                    if (i == 0 || i == flowerbed.Length - 1)
                    {
                        zeroCount++;
                    }
                    continue;
                }
                else
                {
                    if (zeroCount > 0)
                    {
                        canPlaceCount += (zeroCount - 1) / 2;
                    }
                    zeroCount = 0;
                }
            }
            if (zeroCount > 0)
            {
                canPlaceCount += (zeroCount - 1) / 2;
            }
            return canPlaceCount >= n;
        }
        public void Execute()
        {
            Console.WriteLine(CanPlaceFlowers(new int[] { 0, 0, 0, 1 }, 1));
            Console.WriteLine(CanPlaceFlowers(new int[] { 0, 0, 0, 0, 1 }, 2));
            Console.WriteLine(CanPlaceFlowers(new int[] { 0, 0, 1, 0, 0 }, 3));
            Console.WriteLine(CanPlaceFlowers(new int[] { 0 }, 1));
            Console.WriteLine(CanPlaceFlowers(new int[] { 1 }, 1));
            Console.WriteLine(CanPlaceFlowers(new int[] { 0, 0, 0 }, 1));
            Console.WriteLine(CanPlaceFlowers(new int[] { 0, 0, 0 }, 2));
        }
    }
}
