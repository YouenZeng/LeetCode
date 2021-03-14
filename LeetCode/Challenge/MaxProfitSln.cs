using System;

namespace LeetCode.Challenge
{
    class MaxProfitSln : ISolution
    {
        public int MaxProfit(int[] inventory, int orders)
        {
            int mod = 1000000000 + 7;
            long result = 0;

            Array.Sort(inventory);

            int factor = 1;
            for (int i = inventory.Length - 1; i >= 0; i--)
            {
                int gap;
                if (i > 0)
                {
                    gap = inventory[i] - inventory[i - 1];
                }
                else
                {
                    gap = inventory[i];
                }

                if (gap * factor < orders)
                {
                    orders -= gap * factor;

                    long sum = (long) (inventory[i] * 2 - gap + 1) * gap * factor / 2;
                    result += sum % mod;
                    factor++;
                }
                else
                {
                    int g = orders / factor;
                    int left = orders % factor;

                    long sum = (long) (inventory[i] + inventory[i] - g + 1) * g * factor / 2;
                    result += sum;
                    long sum2 = (long) (inventory[i] - g) * left;
                    result += sum2 % mod;

                    return (int) (result % mod);
                }
            }

            return 0;
        }

        public void Execute()
        {
            Console.WriteLine(MaxProfit(new int[] { 701695700, 915736894, 35093938, 364836059, 452183894, 951826038, 861556610, 441929847, 842650446, 858413011, 457896886, 35119509, 776620034, 396643588, 83585103, 681609037 }, 598226067));
            Console.WriteLine(MaxProfit(new int[] {2, 8, 4, 10, 6}, 20));
            Console.WriteLine(MaxProfit(new int[] {2, 5}, 4));
            Console.WriteLine(MaxProfit(new int[] {3, 5}, 6));
            ;
        }
    }
}