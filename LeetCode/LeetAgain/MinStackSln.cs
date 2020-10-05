using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.LeetAgain
{
    class StackNode
    {
        public int Val;
        public int MinValue;
        public StackNode Next;

        public StackNode(int val, int min, StackNode next)
        {
            Val = val;
            MinValue = min;
            Next = next;
        }

        public StackNode(int val, int min) : this(val, min, null)
        {
        }
    }

    public class MinStack : ISolution
    {
        private StackNode head;

        public MinStack()
        {
        }

        public void Push(int x)
        {
            if (head == null)
                head = new StackNode(x, x);
            else
            {
                head = new StackNode(x, Math.Min(x, head.MinValue), head);
            }
        }

        public void Pop()
        {
            head = head.Next;
        }

        public int Top()
        {
            return head.Val;
        }

        public int GetMin()
        {
            return head.MinValue;
        }

        //private readonly Stack<int> _minStack;
        //private readonly Stack<int> _minValTrackStack;

        //private int _currentMinValue;

        ///** initialize your data structure here. */
        //public MinStack()
        //{
        //    _minStack = new Stack<int>();
        //    _minValTrackStack = new Stack<int>();
        //    _currentMinValue = int.MaxValue;
        //}

        //public void Push(int x)
        //{
        //    _minStack.Push(x);

        //    _currentMinValue = _minValTrackStack.Count == 0 ? int.MaxValue : _minValTrackStack.Peek();

        //    _currentMinValue = Math.Min(_currentMinValue, x);

        //    _minValTrackStack.Push(_currentMinValue);
        //}

        //public void Pop()
        //{
        //    _minStack.Pop();
        //    _minValTrackStack.Pop();
        //}

        //public int Top()
        //{
        //    return _minStack.Peek();
        //}

        //public int GetMin()
        //{
        //    return _minValTrackStack.Peek();
        //}
        public void Execute()
        {
            MinStack obj = new MinStack();
            obj.Push(-10);
            obj.Push(14);
            Console.WriteLine(obj.GetMin());
            Console.WriteLine(obj.GetMin());
            obj.Push(-20);
            Console.WriteLine(obj.GetMin());
            Console.WriteLine(obj.GetMin());
            Console.WriteLine(obj.Top());
            Console.WriteLine(obj.GetMin());

            obj.Pop();
            Console.WriteLine(obj.GetMin());

            obj.Push(10);
            obj.Push(-7);

            Console.WriteLine(obj.GetMin());
            obj.Push(-7);
            obj.Pop();
            Console.WriteLine(obj.Top());
            Console.WriteLine(obj.GetMin());

            obj.Pop();
        }
    }
}