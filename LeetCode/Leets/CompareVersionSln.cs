using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Leets
{
    class CompareVersionSln : ISolution
    {
        public int CompareVersion(string version1, string version2)
        {
            string[] v1 = version1.Split('.');
            string[] v2 = version2.Split('.');

            int arrayMinLength = v1.Length > v2.Length ? v2.Length : v1.Length;

            for (int i = 0; i < arrayMinLength; i++)
            {
                if (Convert.ToInt32(v1[i]) == Convert.ToInt32(v2[i]))
                {
                    continue;
                }

                return Convert.ToInt32(v1[i]) > Convert.ToInt32(v2[i]) ? 1 : -1;
            }

            if (v1.Length == v2.Length) return 0;

            if (v1.Length == arrayMinLength)
            {
                for (int i = arrayMinLength ; i < v2.Length ; i++)
                {
                    if (Convert.ToInt32(v2[i]) > 0) return -1;
                }
            }
            else
            {
                for (int i = arrayMinLength ; i < v1.Length ; i++)
                {
                    if (Convert.ToInt32(v1[i]) > 0) return 1;
                }
            }
            return 0;
        }
        public void Execute()
        {
            Console.WriteLine(CompareVersion("1.0", "1"));
        }
    }
}
