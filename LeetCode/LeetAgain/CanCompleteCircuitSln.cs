namespace LeetCode.LeetAgain
{
    public class CanCompleteCircuitSln : ISolution
    {
        /// <summary>
        /// Prove of idea 1: In any station between A and B, let's say C. C will have gas left in our tank,
        ///  if we go from A to that station. We can't reach B from A with some gas(may be 0) left in the tank in C, 
        /// so we can't reach B from C with an empty tank.
        ///
        /// Prove of idea 2: If the gas is more than the cost in total, there must be some stations we have enough gas to go through them.Let's say they are green stations. So the other stations are red. 
        /// The adjacent stations with same color can be joined together as one. Then there must be a red 
        /// station that can be joined into a precedent green station unless there isn't any red station, 
        /// because the total gas is more than the total cost.In other words, all of the stations will join into a green station at last.
        /// </summary>
        /// <param name="gas"></param>
        /// <param name="cost"></param>
        /// <returns></returns>
        public int CanCompleteCircuit2(int[] gas, int[] cost)
        {
            int start = 0;
            int currentTotal = 0;
            int total = 0;

            for (int i = 0; i < gas.Length; i++)
            {
                currentTotal += gas[i] - cost[i];
                total += gas[i] - cost[i];

                if (currentTotal < 0)
                {
                    start = i + 1;
                    currentTotal = 0;
                }
            }

            return total >= 0 ? start : -1;
        }

        public int CanCompleteCircuit(int[] gas, int[] cost)
        {
            //any time, total sum>=0

            int[] gap = new int[gas.Length];
            for (int i = 0; i < gas.Length; i++)
            {
                gap[i] = gas[i] - cost[i];
            }

            for (int i = 0; i < gas.Length;)
            {
                if (gap[i] < 0)
                {
                    i++;
                    continue;
                }

                int tCount = 1;
                int sum = gap[i];
                while (tCount < gas.Length)
                {
                    if (sum + gap[(i + tCount) % gas.Length] < 0)
                    {
                        break;
                    }

                    sum = sum + gap[(i + tCount) % gas.Length];
                    tCount++;
                }

                if (tCount == gas.Length)
                    return i;
                i++;
            }

            return -1;
        }

        public void Execute()
        {
            int[] gas = {1, 2, 3, 4, 5};
            int[] cost = {3, 4, 5, 1, 2};

            CanCompleteCircuit2(gas, cost);
        }
    }
}