namespace LeetCode.LeetAgain
{
    public class CountSubstringsSln : ISolution
    {
        private int count = 0;
        public int CountSubstrings(string s)
        {
            if (s.Length < 2) return s.Length;

            for (int i = 0; i < s.Length; i++)
            {
                CountSubstring(s, i, i);
                CountSubstring(s, i, i + 1);
            }
            return count;
        }

        void CountSubstring(string s, int begin, int end)
        {
            while (begin >= 0 && end < s.Length && s[begin] == s[end])
            {
                count++;
                begin--;
                end++;
            }
        }
        public void Execute()
        {
            CountSubstrings("aaa");
        }
    }
}