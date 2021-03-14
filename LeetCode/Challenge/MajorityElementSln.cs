using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Challenge
{
    class MajorityElementSln : ISolution
    {
        public int MaximumScore(int[] nums, int k)
        {
            int left = k;
            int right = k;

            int result = nums[k];
            int min = nums[k];
            while (left > 0 || right < nums.Length - 1)
            {
                if (left == 0)
                {
                    right++;
                    min = Math.Min(min, nums[right]);
                }
                else if (right == nums.Length - 1)
                {
                    left--;
                    min = Math.Min(min, nums[left]);
                }
                else if (nums[left - 1] > nums[right + 1])
                {
                    left--;
                    min = Math.Min(min, nums[left]);
                }
                else
                {
                    right++;
                    min = Math.Min(min, nums[right]);
                }

                result = Math.Max(result, min * (right - left + 1));
            }

            return result;
        }

        public double MaxAverageRatio(int[][] classes, int extraStudents)
        {
            PriorityQueue<Tuple<double, int>> pq = new PriorityQueue<Tuple<double, int>>(500,
                Comparer<Tuple<double, int>>.Create((t1, t2) => t2.Item1.CompareTo(t1.Item1)));

            for (int i = 0; i < classes.Length; i++)
            {
                int[] c = classes[i];
                pq.Push(new Tuple<double, int>((c[1] - c[0]) / ((double) c[1] * (c[1] + 1)), i));
            }

            int total = classes.Length;
            while (extraStudents > 0)
            {
                Tuple<double, int> top = pq.Top;
                pq.Pop();

                int idx = top.Item2;
                classes[idx][0]++;
                classes[idx][1]++;
                int[] c = classes[idx];

                pq.Push(new Tuple<double, int>((c[1] - c[0]) / (double) (c[1] * (c[1] + 1)), idx));
                extraStudents--;
            }

            double d = 0;
            foreach (int[] c in classes)
            {
                d += c[0] / (double) c[1];
            }

            return d / total;
        }

        public IList<int> MajorityElement(int[] nums)
        {
            List<int> result = new List<int>();
            string s = "";

            int major1 = 0;
            int count1 = 0;
            int major2 = 0;
            int count2 = 0;
            foreach (int n in nums)
            {
                if (n == major1)
                {
                    count1++;
                }
                else if (n == major2)
                {
                    count2++;
                }
                else if (count1 == 0)
                {
                    major1 = n;
                    count1 = 1;
                }
                else if (count2 == 0)
                {
                    major2 = n;
                    count2 = 1;
                }
                else
                {
                    count1--;
                    count2--;
                }
            }

            count1 = 0;
            count2 = 0;
            foreach (int n in nums)
            {
                if (n == major1)
                {
                    count1++;
                }

                if (n == major2)
                {
                    count2++;
                }
            }

            if (count1 >= nums.Length / 3 + 1)
            {
                result.Add(major1);
            }

            if (count2 >= nums.Length / 3 + 1 && major2 != major1)
            {
                result.Add(major2);
            }

            return result;
        }

        public void Execute()
        {
            // [1,4,3,7,4,5]
            // 3

            MaximumScore(new int[] { 1, 4, 3, 7, 4, 5 }, 3);

            // MajorityElement(new int[] {2, 1, 1, 3, 1, 4, 5, 6});
            // MaxAverageRatio(new int[][]
            // {
            //     new int[] {1, 2},
            //     new int[] {3, 5},
            //     new int[] {2, 2},
            // }, 2);
        }
    }
}