using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    class BoxTest
    {
        public void Test()
        {
            int i = 5;
            object obj = i;
            IFormattable ftt = i;
            Console.WriteLine(System.Object.ReferenceEquals(i, obj));
            Console.WriteLine(System.Object.ReferenceEquals(i, ftt));
            Console.WriteLine(System.Object.ReferenceEquals(ftt, obj));
            Console.WriteLine(System.Object.ReferenceEquals(i, (int)obj));
            Console.WriteLine(System.Object.ReferenceEquals(i, (int)ftt));
        }
    }
}
