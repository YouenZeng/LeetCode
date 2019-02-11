using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.LeetAgain
{
    class ToLowerCaseSln : ISolution
    {
        public string ToLowerCase(string str)
        {
            //A 65 Z 90
            //a 97 Z 122
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] >= 65 && str[i]<=90)
                {
                    sb.Append((char)(str[i] + 32));
                }
                else
                {
                    sb.Append(str[i]);
                }
            }
            return sb.ToString();
        }
        public void Execute()
        {
            throw new NotImplementedException();
        }
    }
}
