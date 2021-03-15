using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode.Challenge
{
    class MinMeetingRoomsSln : ISolution
    {
        public int MinMeetingRooms(int[][] intervals)
        {
            int len = intervals.Length;
            int[] start = new int[len];
            int[] end = new int[len];
            for (int i = 0; i < len; i++)
            {
                start[i] = intervals[i][0];
                end[i] = intervals[i][1];
            }
            Array.Sort(start);
            Array.Sort(end);

            int s = 0;
            int e = 0;
            int count = 0;
            while (s < len)
            {
                if (start[s] >= end[e])
                {
                    count -= 1;
                    e++;
                }

                count++;
                s++;
            }

            return count;
        }

        public void Execute()
        {
            MinMeetingRooms(new int[3][] {
                new int[] {0, 30},
                new int[] {5, 10},
                new int[] {15, 20},
            });
        }
    }
}