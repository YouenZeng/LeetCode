using System;

namespace LeetCode.Leets
{
    class RomanToIntSln : ISolution
    {
        public int RomanToInt(string s)
        {
            int result = 0;
            for (int i = s.Length-1; i >=0 ; i--)
            {
                switch (s[i])
                {
                    case 'I':
                        result += (result >= 5 ? -1 : 1);
                        break;
                    case 'V':
                        result += 5;
                        break;
                    case 'X':
                        result +=10*(result >= 50 ? -1 : 1);
                        break;
                    case 'L':
                        result += 50;
                        break;
                    case 'C':
                        result += 100 * (result >= 500 ? -1 : 1);
                        break;
                    case 'D':
                        result += 500;
                        break;
                    case 'M':
                        result += 1000;
                        break;
                    default:
                        result += 0;
                        break;
                }
            }
            return result;
        }
        public void Execute()
        {
            Console.WriteLine(RomanToInt("MCMXCVI"));
        }
    }
}
