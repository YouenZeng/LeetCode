namespace LeetCode.LeetAgain
{
    internal class MySqrtSln : ISolution
    {
        public int MySqrt(int x)
        {
            //=> r(n + 1) = r(n) - f(r(n)) / f'(r(n))
            //=> r(n + 1) = r(n) - (r(n) ^ 2 - x) / 2 * r(n)
            //=> r(n + 1) = r(n) - r(n) / 2 + x / 2 * r(n)
            //=> r(n + 1) = (r(n) + x / r(n)) / 2

            long r = x;
            while(r*r -x > 0)
            {
                r = (r + x / r) / 2;
            }
            return (int)r;
        }
        public void Execute()
        {
            MySqrt(100);
        }
    }
}
