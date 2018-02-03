using System;

namespace LeetCode
{
    class BoxTest
    {
        public void Test()
        {
            int i = 5;
            object obj = i;
            IFormattable ftt = i;
            Console.WriteLine(ReferenceEquals(i, obj));
            Console.WriteLine(ReferenceEquals(i, ftt));
            Console.WriteLine(ReferenceEquals(ftt, obj));
            Console.WriteLine(ReferenceEquals(i, (int)obj));
            Console.WriteLine(ReferenceEquals(i, (int)ftt));
        }
    }
}
