using System;
using System.Collections.Generic;

namespace LeetCode.LeetAgain
{
    public class InsertIntervalSln : ISolution
    {
        public IList<Interval> Insert(IList<Interval> intervals, Interval newInterval)
        {
            var result = new List<Interval>();
            bool applied = false;
            foreach (Interval interval in intervals)
            {
                if (applied)
                {
                    result.Add(interval);
                    continue;
                }
                //case 5
                if (interval.start > newInterval.end)
                {
                    result.Add(newInterval);
                    result.Add(interval);

                    applied = true;
                    continue;
                }
                //case6
                if (newInterval.start > interval.end)
                {
                    result.Add(interval);
                    continue;
                }
                newInterval = new Interval(Math.Min(interval.start, newInterval.start), Math.Max(interval.end, newInterval.end));
            }
            if (applied == false)
            {
                result.Add(newInterval);
            }
            return result;
        }
        void ISolution.Execute()
        {
            Insert(new List<Interval> {
                new Interval(100, 200),
                // new Interval(3, 5),
                // new Interval(6, 7),
                // new Interval(8, 10),
                // new Interval(12, 16),

                }, new Interval(0, 99));

            Insert(new List<Interval> {
                new Interval(100, 200),
                // new Interval(3, 5),
                // new Interval(6, 7),
                // new Interval(8, 10),
                // new Interval(12, 16),

                }, new Interval(0, 100));
        }
    }


    public class Interval
    {
        public int start;
        public int end;
        public Interval() { start = 0; end = 0; }
        public Interval(int s, int e) { start = s; end = e; }
    }

}