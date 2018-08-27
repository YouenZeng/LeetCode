using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode.LeetAgain
{
    class MergeSln : ISolution
    {

        //Definition for an interval.
        public class Interval
        {
            public int start;
            public int end;
            public Interval() { start = 0; end = 0; }
            public Interval(int s, int e) { start = s; end = e; }
        }

        public IList<Interval> Merge(IList<Interval> intervals)
        {
            intervals = intervals.OrderBy(i => i.start).ToList();
            Interval candicate = null;

            IList<Interval> result = new List<Interval>();
            foreach (var item in intervals)
            {
                if (candicate == null)
                {
                    candicate = item;
                    continue;
                }

                if (candicate.end < item.start)
                {
                    result.Add(candicate);
                    candicate = item;
                }
                else
                {
                    if (item.end > candicate.end)
                        candicate.end = item.end;
                }
            }
            if (candicate != null)
                result.Add(candicate);

            return result;
        }

        public void Execute()
        {
            throw new NotImplementedException();
        }
    }
}
