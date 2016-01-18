using System;
using System.Text;

namespace LeetCode.Leets
{
    class AddBinarySln : ISolution
    {
        public string AddBinary(string a, string b)
        {

            char[] arrayA = a.ToCharArray();
            char[] arrayB = b.ToCharArray();

            StringBuilder result = new StringBuilder();

            int aLength = a.Length - 1;
            int bLength = b.Length - 1;
            int carray = 0;

            while (aLength > -1 || bLength > -1 || carray == 1)
            {
                var aItem = (aLength > -1) ? (int)Char.GetNumericValue(arrayA[aLength--]) : 0;
                var bItem = (bLength > -1) ? (int)Char.GetNumericValue(arrayB[bLength--]) : 0;
                var tmp   = aItem ^ bItem ^ carray;

                carray    = ((aItem + bItem + carray) >= 2 ? 1 : 0);
                result    = result.Append(tmp);
            }

            char[] charArray = result.ToString().ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }
        public void Execute()
        {
            Console.WriteLine(AddBinary("1111", "1111"));
        }
    }
}
