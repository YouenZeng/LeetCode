using System;
using System.Collections.Generic;

namespace LeetCode.LeetAgain
{
    class RestoreIpAddressesDfsSln : ISolution
    {
        public IList<string> RestoreIpAddresses(string s)
        {
            IList<string> result = new List<string>();

            RestoreIp(s, result, 0, "", 0);

            return result;
        }

        void RestoreIp(string ip, IList<string> solutions, int idx, string restored, int count)
        {
            if (count > 4) return;

            if (count == 4 && idx == ip.Length) solutions.Add(restored);

            for (int i = 1; i < 4; i++)
            {
                if (idx + i > ip.Length) break;
                string s = ip.Substring(idx,  i);

                if ((s.StartsWith("0") && s.Length > 1) || (i == 3 && Convert.ToInt32(s) >= 256)) continue;

                RestoreIp(ip, solutions, idx + i, restored + s + (count == 3 ? "" : "."), count + 1);
            }
        }

        public void Execute()
        {
            RestoreIpAddresses("0000");
        }
    }
}
