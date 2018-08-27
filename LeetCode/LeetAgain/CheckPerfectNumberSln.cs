﻿using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.LeetAgain
{
    class CheckPerfectNumberSln : ISolution
    {
        public bool CheckPerfectNumber(int num)
        {
            if (num == 1) return false;

            int sum = 1;
            for (int i = 2; i * i < num; i++)
            {
                if (num % i == 0)
                {
                    sum += i;
                    sum += (num / i);
                }
            }
            return sum == num;
        }
        public void Execute()
        {
            throw new NotImplementedException();
        }
    }
}
