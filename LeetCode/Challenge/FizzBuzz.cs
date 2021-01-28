using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace LeetCode.Challenge
{
    public class FizzBuzz
    {
        private readonly int n;

        private readonly AutoResetEvent fizzAutoResetEvent = new AutoResetEvent(false);
        private readonly AutoResetEvent buzzResetEvent = new AutoResetEvent(false);
        private readonly AutoResetEvent fizzBuzzAutoResetEvent = new AutoResetEvent(false);
        private readonly AutoResetEvent numberAutoResetEvent = new AutoResetEvent(true);
        private int current = 1;
        public FizzBuzz(int n)
        {
            this.n = n;
        }

        // printFizz() outputs "fizz".
        public void Fizz(Action printFizz)
        {
            while (fizzAutoResetEvent.WaitOne() && current <= n)
            {
                printFizz();
                //current++;
                numberAutoResetEvent.Set();
            }
        }

        // printBuzzz() outputs "buzz".
        public void Buzz(Action printBuzz)
        {
            while (buzzResetEvent.WaitOne() && current <= n)
            {
                printBuzz();
                //current++;
                numberAutoResetEvent.Set();
            }
        }

        // printFizzBuzz() outputs "fizzbuzz".
        public void Fizzbuzz(Action printFizzBuzz)
        {
            while (fizzBuzzAutoResetEvent.WaitOne() && current<= n)
            {
                printFizzBuzz();
                //current++;
                numberAutoResetEvent.Set();
            }
        }

        // printNumber(x) outputs "x", where x is an integer.
        public void Number(Action<int> printNumber)
        {
            for (; current <= this.n; current++)
            {
                numberAutoResetEvent.WaitOne();
                if (current % 3 == 0 && current % 5 == 0)
                {
                    fizzBuzzAutoResetEvent.Set();
                }
                else if (current % 3 == 0)
                {
                    fizzAutoResetEvent.Set();
                }
                else if (current % 5 == 0)
                {
                    buzzResetEvent.Set();
                }
                else
                {
                    numberAutoResetEvent.Set();
                    printNumber(current);
                }
               
            }
        }
    }

    public class FizzBuzzSln : ISolution
    {
        public void Execute()
        {
            FizzBuzz fb = new FizzBuzz(15);

            Task[] tasks = new Task[4];

            tasks[0] = Task.Run(() =>
            {
                while (true)
                {
                    fb.Fizz(() => Console.WriteLine("fuzz"));
                    Task.Delay(10);
                }
            });
            tasks[1] = Task.Run(() =>
            {
                while (true)
                {
                    fb.Buzz(() => Console.WriteLine("buzz"));
                    Task.Delay(10);
                }
            });
            tasks[2] = Task.Run(() =>
            {
                while (true)
                {
                    fb.Fizzbuzz(() => Console.WriteLine("fuzzBuzz"));
                    Task.Delay(10);
                }
            });
            tasks[3] = Task.Run(() =>
            {
                while (true)
                {
                    fb.Number(Console.WriteLine);
                    Task.Delay(10);
                }
            });

            Task.WaitAll(tasks);
        }
    }
}