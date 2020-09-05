using LeetCode.Infra;
using LeetCode.LeetAgain;
using System;


namespace LeetCode
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine(CRC16.CRC16_ccitt(System.Text.Encoding.ASCII.GetBytes("2020051300U1234567890ABCDEFGHIJKLMN"),0,35));


            //ISolution sln = new ThreeSumSln();
            //sln.Execute();

            //Console.ReadLine();
        }
    }


}