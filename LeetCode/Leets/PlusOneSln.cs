namespace LeetCode.Leets
{
    class PlusOneSln : ISolution
    {
        public int[] PlusOne(int[] digits)
        {

            int length = digits.Length;

            for (int i = length - 1; i >= 0; i--)
            {
                if (digits[i] != 9)
                {
                    digits[i] = digits[i] + 1;
                    break;
                }
                digits[i] = 0;
            }

            if (digits[0] == 0)
            {
                var arr = new int[length + 1];
                arr[0] = 1;
                return arr;
            }
            return digits;
        }


        public void Execute()
        {
            var arr = new int[] { 9, 9, 9 };
            PlusOne(arr);
        }
    }
}
