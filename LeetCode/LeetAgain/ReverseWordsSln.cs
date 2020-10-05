using System;
using System.Linq;
using System.Text;
using System.Xml;

namespace LeetCode.LeetAgain
{
    public class ReverseWordsSln : ISolution
    {
        public string ReverseWords(string s)
        {
            var array = s.Reverse().ToArray();

            int slowIndex = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] != ' ')
                {
                    if (slowIndex != 0)
                    {
                        array[slowIndex++] = ' ';
                    }

                    int start = i;
                    while (start < array.Length && array[start] != ' ')
                    {
                        array[slowIndex++] = array[start++];
                    }

                    Array.Reverse(array, slowIndex - (start - i), start - i);
                    i = start;
                }
            }

            var arr = new char[slowIndex];
            Array.Copy(array, arr, slowIndex);
            return new string(arr);
        }


        void ISolution.Execute()
        {
            System.Console.WriteLine(ReverseWords("  "));
        }
    }
}