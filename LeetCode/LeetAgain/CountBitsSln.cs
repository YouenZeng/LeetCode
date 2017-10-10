namespace LeetCode.LeetAgain
{
    public class CountBitsSln : ISolution
    {
        public int[] CountBits(int num)
        {
            int factor = 1 << 1;
            var result = new int[num + 1];

            if (num == 0) return result;

            if (num == 1)
            {
                result[1] = 1;
                return result;
            }

            while (factor / num <= 1)
            {
                int preFactor = factor >> 1;
                for (int i = preFactor; i <= factor && i <= num; i++)
                {
                    result[i] = result[i % preFactor] + 1;
                }
                factor <<= 1;
            }
            return result;
        }
        public void Execute()
        {
            CountBits(8);
        }
    }
}