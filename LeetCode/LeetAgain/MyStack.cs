using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.LeetAgain
{
    //https://leetcode.com/problems/implement-stack-using-queues/#/description
    public class MyStack : ISolution
    {
        Queue<int> input = new Queue<int>();

        /** Initialize your data structure here. */
        public MyStack()
        {

        }

        /** Push element x onto stack. */
        public void Push(int x)
        {
            input.Enqueue(x);

            //enquede all items back
            for (int i = 0; i < input.Count - 1; ++i)
            {
                input.Enqueue(input.Peek());
                input.Dequeue();
            }
        }

        /** Removes the element on top of the stack and returns that element. */
        public int Pop()
        {
            return input.Dequeue();
        }

        /** Get the top element. */
        public int Top()
        {
            return input.Peek();
        }

        /** Returns whether the stack is empty. */
        public bool Empty()
        {
            return input.Count > 0;
        }
        public void Execute()
        {
            Push(1);
            Push(2);
            Push(3);

            Console.WriteLine(Pop());
            Console.WriteLine(Pop());
            Console.WriteLine(Top());
        }
    }
}
