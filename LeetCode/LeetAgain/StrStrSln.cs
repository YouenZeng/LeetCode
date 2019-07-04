using System;

namespace LeetCode.LeetAgain
{
    public class StrStrSln : ISolution
    {
        public int StrStr(string haystack, string needle)
        {
            if (string.IsNullOrEmpty(needle))
                return 0;
            int hsLength = haystack.Length;
            for (int i = 0; i < hsLength; i++)
            {
                if (haystack[i] == needle[0] && (i + needle.Length <= hsLength))
                {
                    int hsIndex = i;
                    bool fole = false;
                    for (int j = 0; j < needle.Length && hsIndex < hsLength; j++, hsIndex++)
                    {
                        if (needle[j] != haystack[hsIndex])
                        {
                            fole = true;
                            break;
                        }
                    }
                    if(!fole)
                        return i;
                }
            }

            return -1;
        }
        void ISolution.Execute()
        {
            StrStr("mississippi", "issip");
        }
    }
}