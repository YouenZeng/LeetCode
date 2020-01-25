using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.LeetAgain
{
    class TrapSln : ISolution
    {

        /*
         *
         *The idea is: I calculated the stored water at each index a and b in my code.
         * At the start of every loop, I update the current maximum height from left side (that is from A[0,1...a])
         * and the maximum height from right side(from A[b,b+1...n-1]). if(leftmax<rightmax) then,
         * at least (leftmax-A[a]) water can definitely be stored no matter what happens between [a,b]
         * since we know there is a barrier at the rightside(rightmax>leftmax). On the other side,
         * we cannot store more water than (leftmax-A[a]) at index a since the barrier at left is of height leftmax.
         * So, we know the water that can be stored at index a is exactly (leftmax-A[a]).
         * The same logic applies to the case when (leftmax>rightmax).
         * At each loop we can make a and b one step closer.
         * Thus we can finish it in linear time.
         *
         */

        public int Trap(int[] height)
        {
            int left = 0;
            int right = height.Length - 1;

            int leftMax = 0;
            int rightMax = 0;

            int result = 0;

            while (left <= right)
            {
                leftMax = Math.Max(leftMax, height[left]);
                rightMax = Math.Max(rightMax, height[right]);

                if (leftMax < rightMax)
                {
                    result += (leftMax - height[left]);
                    left++;
                }
                else
                {
                    result += (rightMax - height[right]);
                    right--;
                }
            }

            return result;
        }

        public void Execute()
        {
            throw new NotImplementedException();
        }
    }
}