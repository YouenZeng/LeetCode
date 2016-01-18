using System;
using System.Collections.Generic;

namespace LeetCode.Leets
{
    /// <summary>
    /// Implement Queue using Stacks
    /// </summary>
    class QueueSln : ISolution
    {
        private Stack<int> _stack = new Stack<int>();
        readonly Stack<int> _tmpStack = new Stack<int>();
        // Push element x to the back of queue.
        public void Push(int x)
        {
            _stack.Push(x);
        }

        // Removes the element from front of queue.
        public void Pop()
        {
            Peek();
            _tmpStack.Pop();
        }

        // Get the front element.
        public int Peek()
        {
            if (_tmpStack.Count == 0)
            {
                while (_stack.Count > 0)
                {
                    _tmpStack.Push(_stack.Pop());
                }
            }
            return _tmpStack.Peek();
        }

        // Return whether the queue is empty.
        public bool Empty()
        {
            return _stack.Count == 0 && _tmpStack.Count == 0;
        }
        public void Execute()
        {
            throw new NotImplementedException();
        }
    }
}
