using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.LeetAgain
{
    class IsInterleaveSln : ISolution
    {
        public bool IsInterleave(string s1, string s2, string s3)
        {
            //Stack<char> s1Stack = new Stack<char>(s1.ToCharArray());
            //Stack<char> s2Stack = new Stack<char>(s2.ToCharArray());

            //Stack<char> s3Stack = new Stack<char>(s3.ToCharArray());

            int s1Index = 0;
            int s2Index = 0;
            int s3Index = 0;

            while (s1Index < s1.Length && s2Index < s2.Length)
            {
                int c = s3[s3Index];
                if (s1[s1Index] == c)
                {
                    s1Index++;
                    s3Index++;
                }

                if (s2[s2Index] == c)
                {
                    s2Index++;
                    s3Index++;
                    continue;
                }
            }

            while (s1Index < s1.Length)
            {
                int c = s3[s3Index];

                if (s1[s1Index] == c)
                {
                    s1Index++;
                    s3Index++;
                    continue;
                }

                if (s2[s2Index] == c)
                {
                    s2Index++;
                    s3Index++;
                    continue;
                }

                while (s2Index < s2.Length)
                {
                    if (s2[s2Index] == c)
                    {
                        s2Index++;
                        s3Index++;
                        continue;
                    }
                }

                if (s3Index == s3.Length) return true;

                if (s1Index < 0 || s2Index < 0) return false;
            }

            return false;
        }
        public void Execute()
        {
            throw new NotImplementedException();
        }
    }
}
