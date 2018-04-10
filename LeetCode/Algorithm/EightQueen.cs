using System;

namespace LeetCode.Algorithm
{
    class EightQueen
    {
        private static bool IsConsistend(int[] q, int n)
        {
            for (int i = 0; i < n; i++)
            {
                if (q[i] == q[n]) return false;
                if (q[i] - q[n] == n - i) return false;
                if (q[n] - q[i] == n - i) return false;
            }

            return true;
        }

        private static int countEnum = 0;

        private static void PrintQueens(int[] q)
        {
            countEnum++;
        }

        private static void Enumerate(int N)
        {
            int[] a = new int[N];
            Enumerate(a, 0);
        }
        
        /// <summary>
        /// Recursive 
        /// </summary>
        /// <param name="q"></param>
        /// <param name="n"></param>
        private static void Enumerate(int[] q, int n)
        {
            int N = q.Length;
            if (N == n) PrintQueens(q);

            else
            {
                for (int i = 0; i < N; i++)
                {
                    q[n] = i;
                    if (IsConsistend(q, n))
                    {
                        Enumerate(q, n + 1);
                    }
                }
            }
        }

        public static void Queen(int n)
        {
            int[] a = new int[20];

            int k = 1;
            int count = 0;
            a[k] = 1;
            while (k > 0)
            {
                // k<=n 是否越界
                // a[k]<=n 是否探索完毕所有该层内容
                if (k <= n && a[k] <= n)
                {
                    if (IsConsistend(a, k))
                    {
                        //可以放置，去下一行
                        k++;
                        a[k] = 1;
                    }
                    else
                    {
                        //不能放置，跳转到下一列
                        a[k]++;
                    }
                }
                else
                {
                    //满足条件的，输出之
                    if (k > n)
                    {
                        count++;
                    }

                    //退回上一步
                    k--;
                    //试探下一个位置
                    a[k]++;
                }
            }

            Console.WriteLine(count);
        }
    }
}