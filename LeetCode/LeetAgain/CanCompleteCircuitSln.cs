using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.LeetAgain
{
    public class CanCompleteCircuitSln : ISolution
    {
        public int CanCompleteCircuit(int[] gas, int[] cost)
        {
            int stationCount = gas.Length;
            int tank = 0;
            int start = 0;
            int total = 0;
            for (int i = 0; i < stationCount; i++)
            {
                tank += gas[i] - cost[i];
                //if car fails at 'start', record the next station
                if (tank < 0)
                {
                    start = i + 1;
                    total += tank;
                    tank = 0;
                }
            }
            return total + tank < 0 ? -1 : start;

        }
        public void Execute()
        {
            int[] gas = { 1, 2, 3, 3 };
            int[] cost = { 2, 1, 5, 1 };

            CanCompleteCircuit(gas, cost);
        }
    }
}
