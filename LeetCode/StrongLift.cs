using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    public class StrongLift
    {
        public void PlateCombine(int target)
        {
            int barWeight = 45;
            if (target < barWeight)
            {
                return;
            }

            if (target % 5 != 0)
            {
                target -= target % 5;
            }
            int plateWeight = target - barWeight;

            //plate SKU
            Dictionary<int, int> availablePlates = new Dictionary<int, int>()
            {
                {90,10 },
                {70,10 },
                {50,10 },
                {20,10 },
                {10,10 },
                {5,10 }
            };

            List<int> plateUnit = new List<int>()
            {
                90,70,50,20,10,5
            };

            Queue<int> plates = new Queue<int>();
            foreach (var item in plateUnit)
            {
                for (int i = 0; i < availablePlates[item]; i++)
                {
                    plates.Enqueue(item);
                }
            }
            PlateHandler(plates, new Stack<int>(), plateWeight);
        }

        private void PlateHandler(Queue<int> plates, Stack<int> steps, int target)
        {
            if (target < 0)
            {
                return;
            }
            if (target == 0)
            {
                steps.ToList().ForEach(s => Console.WriteLine(s));
                return;
            }
            if (plates.Count == 0)
            {
                return;
            }
            var item = plates.Dequeue();
            if (target >= item)
            {
                target -= item;
                steps.Push(item);
                PlateHandler(plates, steps, target);
                steps.Pop();
            }
            else
            {
                PlateHandler(plates, steps, target);
            }

            plates.Enqueue(item);
        }

    }
}
