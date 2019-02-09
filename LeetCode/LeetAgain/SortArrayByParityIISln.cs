namespace LeetCode.LeetAgain
{
    internal class SortArrayByParityIISln : ISolution
    {
        public int[] SortArrayByParityII(int[] A)
        {
            int arrayLength = A.Length;

            int oddIndex = 1;
            int evenIndex = 0;

            while (oddIndex < arrayLength && evenIndex < arrayLength)
            {
                while (oddIndex < arrayLength && A[oddIndex] % 2 == 1)
                {
                    oddIndex += 2;
                }
                while (evenIndex < arrayLength && A[evenIndex] % 2 == 0)
                {
                    evenIndex += 2;
                }

                if (oddIndex < arrayLength && evenIndex < arrayLength)
                {
                    Swap(A, oddIndex, evenIndex);
                }

            }
            return A;
        }

        private void Swap(int[] A, int i,int j)
        {
            int temp = A[i];
            A[i] = A[j];
            A[j] = temp;
        }

        public void Execute()
        {
            SortArrayByParityII(new int[] { 2, 1, 3, 4 });
        }
    }
}
