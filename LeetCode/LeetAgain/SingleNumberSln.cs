namespace LeetCode.LeetAgain
{
    public class SingleNumberSln : ISolution
    {
        public int SingleNumberI(int[] nums)
        {
            int r = 0;
            foreach (var num in nums)
            {
                r ^= num;
            }

            return r;
        }

        /// <summary>
        /// 137
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        public int SingleNumberII(int[] nums)
        {
            int x1 = 0, x2 = 0, mask = 0;

            foreach (int i in nums)
            {
                x2 ^= x1 & i;
                x1 ^= i;
                mask = ~(x1 & x2);
                x2 &= mask;
                x1 &= mask;
            }

            return x1 | x2; // Since p = 1, in binary form p = '01', then p1 = 1, so we should return x1. 
            // If p = 2, in binary form p = '10', then p2 = 1, and we should return x2.
            // Or alternatively we can simply return (x1 | x2).
        }

        public int SingleNumberII_1(int[] nums)
        {
            int[] count = new int[32];
            int result = 0;
            for (int i = 0; i < 32; i++)
            {
                for (int j = 0; j < nums.Length; j++)
                {
                    if (((nums[j] >> i) & 1) == 1)
                    {
                        count[i]++;
                    }
                }

                result |= ((count[i] % 3) << i);
            }

            return result;
        }

        /// <summary>
        /// 260
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        public int[] SingleNumber(int[] nums)
        {
            //1. find xor of these two X1
            //2. pick a random bit b which bit is 1, then that bit of n1 != n2
            //3. X1 xor with all nums that bit b is 1   -> n1
            //4. X1 xor with all nums that bit b is 0   -> n2
            var x1 = 0;
            foreach (var num in nums)
            {
                x1 ^= num;
            }

            int mask = 1;
            for (int i = 0; i < 32; i++)
            {
                mask = mask << 1;
                if ((x1 & mask) == mask)
                {
                    break;
                }
            }

            int n1 = x1;
            int n2 = x1;

            foreach (var num in nums)
            {
                if ((num & mask) == mask)
                {
                    n1 ^= num;
                }
                else
                {
                    n2 ^= num;
                }
            }

            return new[] {n1, n2};
        }

        public void Execute()
        {
            SingleNumber(new[] {1, 1, 2, 2, 3, 3, 6, 6, 23, 7, 8, 8, 12, 12});
            SingleNumberII_1(new[] {1, 1, 1, 3, 3, 3, 7, 7, 7, 9});
        }
    }
}