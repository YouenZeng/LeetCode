using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Security.Cryptography;
using System.Text;

namespace LeetCode.LeetAgain
{
    class IsInterleaveSln : ISolution
    {
        public bool IsInterleave(string s1, string s2, string s3)
        {
            if (s1.Length + s2.Length != s3.Length) return false;
            bool[,] cache = new bool[s1.Length, s2.Length];
            //if ((s1.length() + s2.length()) != s3.length()) return false;

            //boolean[][] matrix = new boolean[s2.length() + 1][s1.length() + 1];

            //matrix[0][0] = true;

            //for (int i = 1; i < matrix[0].length; i++)
            //{
            //    matrix[0][i] = matrix[0][i - 1] && (s1.charAt(i - 1) == s3.charAt(i - 1));
            //}

            //for (int i = 1; i < matrix.length; i++)
            //{
            //    matrix[i][0] = matrix[i - 1][0] && (s2.charAt(i - 1) == s3.charAt(i - 1));
            //}

            //for (int i = 1; i < matrix.length; i++)
            //{
            //    for (int j = 1; j < matrix[0].length; j++)
            //    {
            //        matrix[i][j] = (matrix[i - 1][j] && (s2.charAt(i - 1) == s3.charAt(i + j - 1)))
            //                       || (matrix[i][j - 1] && (s1.charAt(j - 1) == s3.charAt(i + j - 1)));
            //    }
            //}

            //return matrix[s2.length()][s1.length()];




            //return Dfs(s1, s2, s3, 0, 0, 0, cache);
        }

        public void Execute()
        {
            string s1 = "aabcc";
            string s2 = "dbbca";
            string s3 = "aadbbcbcac";

            Console.WriteLine(IsInterleave(s1, s2, s3));
        }
    }
}
