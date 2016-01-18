using System;

namespace LeetCode.Leets
{
    class FirstBadVersionSln : ISolution
    {
        public int FirstBadVersion(int n)
        {
            return BadVersionBst(1, n);
        }

        public int BadVersionBst(int m, int n)
        {

            if (n - m == 1 || n == m)
            {
                if (IsBadVersion(m)) return m;
                return n;
            }
            int mid = m + (n - m) / 2 ;

            Console.WriteLine("m:{0},n{1},mid:{2}", m, n, mid);
            if (IsBadVersion(mid))
            {
                return BadVersionBst(m, mid);
            }
            return BadVersionBst(mid, n);
        }

        public bool IsBadVersion(int version)
        {
            if (version >= 1) return true;
            return false;
        }

        public void Execute()
        {
            Console.WriteLine(FirstBadVersion(3));
        }
    }

}
