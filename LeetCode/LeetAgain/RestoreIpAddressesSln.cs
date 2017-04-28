using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.LeetAgain
{
    class RestoreIpAddressesSln : ISolution
    {
        public IList<string> RestoreIpAddresses(string s)
        {
            IList<string> result = new List<string>();

            int sLength = s.Length ;
            for (int i = 1; i < 4 && i < sLength - 2; i++)
            {
                for (int j = i + 1; j < i + 4 && j < sLength - 1; j++)
                {
                    for (int k = j + 1; k < j + 4 && k < sLength; k++)
                    {
                        string s1 = s.Substring(0, i);
                        string s2 = s.Substring(i, j-i);
                        string s3 = s.Substring(j, k-j);
                        string s4 = s.Substring(k, sLength-k);

                        if (IsValid(s1)
                            && IsValid(s2)
                            && IsValid(s3)
                            && IsValid(s4)
                        )
                        {
                            result.Add(s1 + "." + s2 + "." + s3 + "." + s4);
                        }
                    }
                }
            }

            return result;
        }

        bool IsValid(string s)
        {
            if (s.Length > 3 || s.Length == 0 || (s[0] == '0' && s.Length > 1) || Convert.ToInt32(s) > 255)
                return false;

            return true;
        }

        public void Execute()
        {
            RestoreIpAddresses("0000");
        }
    }
}
