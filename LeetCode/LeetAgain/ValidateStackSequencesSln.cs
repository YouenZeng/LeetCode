using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.LeetAgain
{
    class ValidateStackSequencesSln : ISolution
    {
        public bool ValidateStackSequences(int[] pushed, int[] popped)
        {
            int pushIndex = 0;
            int popIndex = 0;
            Stack<int> stack = new Stack<int>();
            int itemCount = pushed.Length;
            while (true)
            {
                if (popIndex == itemCount) return true;

                if (stack.Count > 0 && stack.Peek() == popped[popIndex])
                {
                    stack.Pop();
                    popIndex++;
                    continue;
                }
                if (pushIndex == itemCount) return false;

                stack.Push(pushed[pushIndex]);
                pushIndex++;
            }
        }
        public void Execute()
        {
            Console.WriteLine(ValidateStackSequences(new int[] { 1, 2, 3, 4, 5 }, new int[] { 5, 4,3,2,1 }));
            Console.WriteLine(ValidateStackSequences(new int[] { 1, 2, 3, 4, 5 }, new int[] { 5, 4, 2,3,1 }));
            Console.WriteLine(ValidateStackSequences(new int[] { 1, 2, 3, 4, 5 }, new int[] { 1,2,3,4,5 }));

        }
    }
}
