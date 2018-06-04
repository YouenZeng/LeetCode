namespace LeetCode.LeetAgain
{
    class FindComplementSln : ISolution
    {
        public int FindComplement(int num)
        {
            if (num == 0) return 1;
            int result = 0;
            int bitCount = 0;
            while (num != 0)
            {
                int mod = num % 2;
                num = num / 2;
                if (mod == 0 && num > 0)
                {
                    result += (1 << bitCount);
                }
                bitCount++;
            }
            return result;
        }
        public void Execute()
        {
            FindComplement(1);
        }
    }
}
