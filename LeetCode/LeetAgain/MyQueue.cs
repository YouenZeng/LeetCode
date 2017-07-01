using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.LeetAgain
{
    /**
 * Your MyQueue object will be instantiated and called as such:
 * MyQueue obj = new MyQueue();
 * obj.Push(x);
 * int param_2 = obj.Pop();
 * int param_3 = obj.Peek();
 * bool param_4 = obj.Empty();
 */
    public class MyQueue : ISolution
    {
        private Stack<int> output;
        private Stack<int> input;
        /** Initialize your data structure here. */
        public MyQueue()
        {
            output = new Stack<int>();
            input = new Stack<int>();
        }

        /** Push element x to the back of queue. */
        public void Push(int x)
        {
            input.Push(x);
        }

        /** Removes the element from in front of queue and returns that element. */
        public int Pop()
        {
            QueueExchange();
            return output.Pop();
        }

        private void QueueExchange()
        {
            if (output.Count == 0)
            {
                while (input.Count > 0)
                    output.Push(input.Pop());
            }

        }

        /** Get the front element. */
        public int Peek()
        {
            QueueExchange();
            return output.Peek();
        }

        /** Returns whether the queue is empty. */
        public bool Empty()
        {
            return (output.Count + input.Count) == 0;
        }
        public void Execute()
        {
            for (int i = 0; i < 10; i++)
            {
                int item = i;
                Push(i);
            }

            Console.WriteLine(Pop());

            Push(11);
            Push(12);

            Console.WriteLine(Pop());

            while (Empty() == false)
                Console.WriteLine(Pop());
        }
    }
}
