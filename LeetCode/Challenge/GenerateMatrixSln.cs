namespace LeetCode.Challenge
{
    class GenerateMatrixSln : ISolution
    {
        public int[][] GenerateMatrix(int n)
        {
            int[][] result = new int[n][];
            for (int i = 0; i < n; i++)
            {
                result[i] = new int[n];
            }

            GenerateMatrix(result, 0, n, 1);

            return result;
        }

        private void GenerateMatrix(int[][] matrix, int startIndex, int width, int numStart)
        {
            if (width < 0)
            {
                return;
            }

            int lowerBound = startIndex;
            int upperBound = startIndex + width - 1;
            for (int i = lowerBound; i <= upperBound; i++)
            {
                matrix[lowerBound][i] = numStart + (i - lowerBound);
                matrix[upperBound][i] = numStart + 2 * width + (width - 2) - (i - lowerBound) - 1;
            }

            for (int i = lowerBound + 1; i < upperBound; i++)
            {
                matrix[i][lowerBound] = numStart + 2 * width + (width - 2) * 2 - (i - lowerBound);
                matrix[i][upperBound] = numStart + width + i - lowerBound - 1;
            }

            GenerateMatrix(matrix, startIndex + 1, width - 2, numStart + 4 * width - 4);
        }

        public void Execute()
        {
            GenerateMatrix(1);
            GenerateMatrix(4);
            GenerateMatrix(5);

            GenerateMatrix(4);
        }
    }
}