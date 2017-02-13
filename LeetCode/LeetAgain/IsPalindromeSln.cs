
namespace LeetCode.LeetAgain
{
    public class IsPalindromeSln : ISolution
    {
        public bool IsPalindrome(string s)
        {
            if (string.IsNullOrEmpty(s)) return true;

            int stringLenth = s.Length;
            int startIndex = 0;
            int endIndex = s.Length - 1;
            while (startIndex < endIndex)
            {
                char startChar = s[startIndex];

                if (char.IsLetterOrDigit(startChar) == false)
                {
                    startIndex++;
                    continue;
                }
                char endChar = s[endIndex];
                if (char.IsLetterOrDigit(endChar) == false)
                {
                    endIndex--;
                    continue;
                }

                if (char.ToLower(startChar) == char.ToLower(endChar))
                {
                    startIndex++;
                    endIndex--;
                    continue;
                }
                else
                {
                    return false;
                }
            }
            return true;
        }
        void ISolution.Execute()
        {
            System.Console.WriteLine(IsPalindrome("a"));;
        }
    }
}