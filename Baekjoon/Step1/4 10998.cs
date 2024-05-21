using System;

namespace Baekjoon10998
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            string[] ss = s.Split();
            int p = int.Parse(ss[0]);
            int q = int.Parse(ss[1]);
            Console.WriteLine(p*q);

        }
    }
}