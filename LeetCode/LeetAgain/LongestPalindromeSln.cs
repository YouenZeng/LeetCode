namespace LeetCode.LeetAgain
{
    public class LongestPalindromeSln : ISolution
    {
        private int start, maxLength;
        public string LongestPalindrome(string s)
        {
            if (s.Length < 2) return s;

            for (int i = 0; i < s.Length; i++)
            {
                DpPalindromic(s, i, i);
                DpPalindromic(s, i, i + 1);
            }
            return s.Substring(start, maxLength);
        }
        int count;
        void DpPalindromic(string s, int begin, int end)
        {
            while (begin >= 0 && end < s.Length && s[begin] == s[end])
            {
                count++;
                begin--;
                end++;
            }

            if (maxLength < end - begin - 1)
            {
                start = begin + 1;
                maxLength = end - begin - 1;
            }
        }
        void ISolution.Execute()
        {
            LongestPalindrome("aaa");
        }
    }
}