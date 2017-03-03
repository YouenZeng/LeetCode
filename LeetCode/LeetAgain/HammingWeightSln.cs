
namespace LeetCode.LeetAgain
{
    public class HammingWeightSln : ISolution
    {
        public int HammingWeight(uint n)
        {
            uint startMask = 1;
            int weight = 0;
            for (int i = 0; i < 32; i++)
            {
                if ((n | startMask) == n)
                {
                    weight++;
                }
                
                startMask = startMask << 1;
            }
            return weight;
        }
        void ISolution.Execute()
        {
            System.Console.WriteLine(HammingWeight(11));
        }
    }
}