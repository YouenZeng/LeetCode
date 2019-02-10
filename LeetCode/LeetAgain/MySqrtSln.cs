namespace LeetCode.LeetAgain
{
    internal class MySqrtSln : ISolution
    {
        public int MySqrt(int x)
        {
            int max = 46340;
            int min = 1;

            while (min < max)
            {
                int mid = min + (max - min) / 2;
                if (mid * mid > x)
                {
                    max = mid;
                }
                else
                {
                    min = mid + 1;
                }
            }
            if (min * min > x) min = min - 1;
            return min;
        }
        public void Execute()
        {
            MySqrt(100);
        }
    }
}
