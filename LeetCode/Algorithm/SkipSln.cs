using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Algorithm
{
    class SkipSln : ISolution
    {
        public List<int> SkipLamp(int startIndex, int step, int count)
        {
            int currentIndex = 0;
            List<int> inputList = new List<int>();
            while (++currentIndex <= count)
                inputList.Add(currentIndex);

            List<int> result = new List<int>();
            int totalIndex = count - 1;
            while (inputList.Count > 0)
            {
                int currentLoopCount = (totalIndex - startIndex) / step;
                if (currentLoopCount == 0)
                {
                    if (step % (totalIndex - startIndex) != 0)
                    {
                        startIndex = step % (totalIndex - startIndex);
                        continue;
                    }
                }
                List<int> temp = new List<int>();
                while (currentLoopCount >= 0)
                {
                    temp.Add(inputList[startIndex + currentLoopCount * step]);
                    inputList.Remove(inputList[startIndex + currentLoopCount * step]);
                    currentLoopCount--;
                }
                startIndex = step - (totalIndex - startIndex) % step - 1;
                totalIndex = inputList.Count - 1;
                temp.Reverse();
                result.AddRange(temp);
            }

            return result;
        }
        public void Execute()
        {
            SkipLamp(4, 5, 13);
        }
    }
}
