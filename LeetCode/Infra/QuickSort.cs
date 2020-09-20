namespace LeetCode.Infra
{
    public class QuickSortSln : ISolution
    {
        public void QuickSort(int[] arr, int start, int end)
        {
            if (start < end)
            {
                var pivot = Parittion(arr, start, end);

                QuickSort(arr, start, pivot - 1);
                QuickSort(arr, pivot + 1, end);
            }
        }


        private int Parittion(int[] arr, int start, int end)
        {
            var pivot  = arr[end];
            int i = start - 1;

            for (int j = start; j < end; j++)
            {
                if (arr[j] < pivot)
                {
                    i = i + 1;
                    Swap(arr, i, j);
                }
            }

            Swap(arr, i + 1, end);
            return i + 1;
        }

        private void Swap(int[] arr, int from, int to)
        {
            var t = arr[to];
            arr[to] = arr[from];
            arr[from] = t;
        }


        public void Execute()
        {
            var arr = new int[] {1, 1, 25, 6, 13, 4, 9, 10, 22};
            QuickSort(arr, 0, arr.Length - 1);
        }
    }
}