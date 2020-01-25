using System;
using System.Collections.Generic;

namespace LeetCode.LeetAgain
{
    internal class FindRestaurantSln : ISolution
    {
        public string[] FindRestaurant(string[] list1, string[] list2)
        {
            Dictionary<string, int> list1Dict = new Dictionary<string, int>();

            for (int i = 0; i < list1.Length; i++)
            {
                list1Dict.Add(list1[i], i);
            }

            Dictionary<int, List<string>> sumItem = new Dictionary<int, List<string>>();

            int min = int.MaxValue;
            for (int i = 0; i < list2.Length; i++)
            {
                string currentItem = list2[i];
                if (list1Dict.ContainsKey(currentItem))
                {
                    int sum = list1Dict[currentItem] + i;
                    if (sumItem.ContainsKey(sum))
                    {
                        sumItem[sum].Add(currentItem);
                    }
                    else
                    {
                        sumItem.Add(sum, new List<string> { currentItem });
                    }

                    min = Math.Min(sum, min);
                }
            }

            return sumItem[min].ToArray();

        }
        public void Execute()
        {
            FindRestaurant(new[] { "Shogun", "Tapioca Express", "Burger King", "KFC" },
                new[] { "Piatti", "The Grill at Torrey Pines", "Hungry Hunter Steakhouse", "Shogun" });
        }
    }
}
