using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.LeetAgain
{
    class CustomSortStringSln : ISolution
    {
        public string CustomSortString(string S, string T)
        {
            Dictionary<char, int> charSort = new Dictionary<char, int>();

            for (char start = 'a'; start <= 'z'; start++)
            {
                charSort.Add(start, 30);
            }

            for (int i = 0; i < S.Length; i++)
            {
                charSort[S[i]] = i;
            }
            var arr = T.ToCharArray();
            Sort(arr, charSort);

            return string.Join("", arr);

        }

        public static void Sort(char[] numbers, Dictionary<char, int> charSort)
        {
            Sort(numbers, 0, numbers.Length - 1, charSort);
        }

        private static void Sort(char[] numbers, int left, int right, Dictionary<char, int> charSort)
        {
            if (left < right)
            {
                char middle = numbers[(left + right) / 2];
                int i = left - 1;
                int j = right + 1;
                while (true)
                {
                    while (charSort[numbers[++i]] < charSort[middle]) ;

                    while (charSort[numbers[--j]] > charSort[middle]) ;

                    if (i >= j)
                        break;

                    Swap(numbers, i, j);
                }

                Sort(numbers, left, i - 1, charSort);
                Sort(numbers, j + 1, right, charSort);
            }
        }

        private static void Swap(char[] numbers, int i, int j)
        {
            char number = numbers[i];
            numbers[i] = numbers[j];
            numbers[j] = number;
        }

        public void Execute()
        {
            CustomSortString("cba", "abcd");
        }
    }
}
