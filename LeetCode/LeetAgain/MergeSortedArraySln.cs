namespace LeetCode.LeetAgain
{
    public class MergeSortedArraySln : ISolution
    {
        public void Merge(int[] nums1, int m, int[] nums2, int n)
        {
            int total = m + n - 1;
            while (total > 0)
            {
                if (nums1[m - 1] > nums2[n - 1])
                {
                    nums1[total] = nums1[m - 1];
                    m--;
                    total--;
                }
                else
                {
                    nums1[total] = nums2[n - 1];
                    n--;
                    total--;
                }
            }

            while (n > 0)
            {
                nums1[m + n - 1] = nums2[n - 1];
                n--;
            }

            while (m > 0)
            {
                nums1[m + n - 1] = nums1[m - 1];
                m--;
            }
        }

        public void Execute()
        {
            Merge(new int[] {11, 12, 31, 0, 0, 0}, 3, new int[] {2, 5, 256}, 3);
        }
    }
}