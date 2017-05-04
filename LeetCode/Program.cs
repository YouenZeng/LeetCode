using LeetCode.LeetAgain;

namespace LeetCode
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                ISolution sln = new DecodeStringSln();
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

