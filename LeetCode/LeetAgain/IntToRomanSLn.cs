using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode.LeetAgain
{
    class IntToRomanSLn : ISolution
    {
        public string IntToRoman(int num)
        {
            string result = string.Empty;

            var l = new List<int>()
            {
                1000,
                900,
                500,
                400,
                100,
                90,
                50,
                40,
                10,
                9,
                5,
                4,
                1,
            };
            var l2 = new List<string>()
            {
                "M",
                "CM",
                "D",
                "CD",
                "C",
                "XC",
                "L",
                "XL",
                "X",
                "IX",
                "V",
                "IV",
                "I",
            };

            for (int i = 0; i < l.Count; i++)
            {
                if (l2[i].Length > 1)
                {
                    if (num / l[i] > 0)
                    {
                        num -= l[i];
                        result += l2[i];
                    }
                }
                else
                {
                    while (num >= l[i])
                    {
                        num -= l[i];
                        result += l2[i];
                    }
                }
            }

            return result;
        }

        public void Execute()
        {
            IntToRoman(180);
            IntToRoman(4);
            IntToRoman(9);
            IntToRoman(10);
            IntToRoman(189);
        }
    }
}