namespace LeetCode.LeetAgain
{
    class MoveZeroesSln : ISolution
    {
        public void MoveZeroes(int[] nums)
        {
            if (nums.Length <= 1) return;
            int firstNonZeroIndex = 0;
            int firstZeroIndex = 0;

            while (firstZeroIndex < nums.Length && firstNonZeroIndex < nums.Length)
            {

                if (nums[firstZeroIndex] != 0) { firstZeroIndex++; continue; }
                if (nums[firstNonZeroIndex] == 0) { firstNonZeroIndex++; continue; }
                if (firstNonZeroIndex < firstZeroIndex) { firstNonZeroIndex++; }

                if (firstNonZeroIndex > firstZeroIndex)
                {
                    nums[firstZeroIndex] = nums[firstNonZeroIndex];
                    nums[firstNonZeroIndex] = 0;
                }
            }
        }
        public void Execute()
        {
            MoveZeroes(new int[] { 1,0,3,12,0,4 });
        }
    }
}
