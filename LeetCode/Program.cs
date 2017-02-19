using LeetCode.LeetAgain;

namespace LeetCode
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                NumArray arr = new NumArray(new [] { -2, 0, 3, -5, 2, -1 });
                ISolution sln = new MinimumTotalSln();
                sln.Execute();
            }
            catch (System.Exception ex)
            {
                System.Console.WriteLine(ex.Message);
                System.Console.WriteLine(ex.StackTrace);
            }
        }
    }
}

