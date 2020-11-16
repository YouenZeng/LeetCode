using System.Collections.Generic;

namespace LeetCode.Hs
{
    public class Tracker
    {
        public void Run()
        {
            var a = new List<Minion>()
            {
                new Minion() {Attack = 2, Health = 2},
                new Minion() {Attack = 1, Health = 2},
            };

            var b = new List<Minion>()
            {
                new Minion() {Attack = 2, Health = 2},
                new Minion() {Attack = 1, Health = 2},
            };

            int aLeft = a.Count;
            int bLeft = b.Count;

            while (aLeft > 0 || bLeft > 0)
            {
                
            }
        }
    }

    public class Minion
    {
        public int Attack { get; set; }
        public int Health { get; set; }
    }
}