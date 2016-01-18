using System;

namespace LeetCode.Leets
{
    class MyAtoiSln : ISolution
    {
        /// <summary>
        /// 参数nptr字符串，如果第一个非空格字符存在，是数字或者正负号则开始做类型转换，
        /// 之后检测到非数字(包括结束符 \0) 字符时停止转换，返回整型数。否则，返回零。
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public int MyAtoi(string str)
        {

            int startIndex = 0;
            int sign = 1;
            int temp = 0;
            if (string.IsNullOrEmpty(str)) return 0;
            while (startIndex < str.Length && str[startIndex] == ' ')
            {
                startIndex++;
            }

            if (startIndex < str.Length && (str[startIndex] == '+' || str[startIndex] == '-'))
            {
                sign = 1 - 2 * (str[startIndex++] == '-' ? 1 : 0);
            }

            while (startIndex<str.Length && str[startIndex] >= '0' && str[startIndex] <= '9')
            {
                if (temp > int.MaxValue / 10 || (temp == int.MaxValue / 10 && str[startIndex] - '0' > 7))
                {
                    if (sign == 1) return int.MaxValue;
                    return int.MinValue;
                }
                temp = 10 * temp + (str[startIndex++] - '0');
            }

            return temp * sign;
        }
        public void Execute()
        {
            Console.WriteLine(MyAtoi("2147483648"));
            Console.WriteLine(MyAtoi("+12345"));
            Console.WriteLine(MyAtoi("112345"));
            Console.WriteLine(MyAtoi("-'12345"));
            Console.WriteLine(MyAtoi("'12*345"));
            Console.WriteLine(MyAtoi("'12-345"));
            Console.WriteLine(MyAtoi(""));
            Console.WriteLine(MyAtoi("-123456-"));
            Console.WriteLine(MyAtoi(" "));
        }
    }
}
