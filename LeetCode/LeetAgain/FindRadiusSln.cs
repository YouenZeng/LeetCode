using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.LeetAgain
{
    class FindRadiusSln : ISolution
    {
        public int FindRadius(int[] houses, int[] heaters)
        {
            Array.Sort(houses);

            int result = int.MinValue;

            foreach (int house in houses)
            {
                int index = Array.BinarySearch(heaters, house);

                if (index < 0)
                {
                    index = (index + 1) * -1;
                }

                int dist1 = index - 1 >= 0 ? house - heaters[index - 1] : int.MaxValue;
                int dist2 = index < heaters.Length ? heaters[index] - house : int.MaxValue;

                result = Math.Max(result, Math.Min(dist1, dist2));
            }
            return result;

        }
        public void Execute()
        {
            throw new NotImplementedException();
        }
    }
}
