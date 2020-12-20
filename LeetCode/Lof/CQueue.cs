using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Lof
{
    public class CQueue:ISolution
    {
        private Stack<int> stack1;
        private Stack<int> stack2;

        public CQueue()
        {
            stack1 = new Stack<int>();
            stack2 = new Stack<int>();
        }

        /*
         1,2,3,4,5

             
             */

        public void AppendTail(int value)
        {
            stack1.Push(value);
        }

        public int DeleteHead()
        {
            if (stack2.Count == 0 && stack1.Count == 0)
            {
                return -1;
            }
            if (stack2.Count == 0)
            {
                while (stack1.Count > 0)
                {
                    stack2.Push(stack1.Pop());
                }
            }

            return stack2.Pop();
        }

        public void Execute()
        {
            AppendTail(1);
            AppendTail(2);
            AppendTail(3);
            AppendTail(4);
            Console.WriteLine(DeleteHead());
            AppendTail(5);
            Console.WriteLine(DeleteHead());
            Console.WriteLine(DeleteHead());
            Console.WriteLine(DeleteHead());
            Console.WriteLine(DeleteHead());
            Console.WriteLine(DeleteHead());
            Console.WriteLine(DeleteHead());
        }
    }

}
