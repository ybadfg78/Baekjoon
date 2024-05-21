using System;

namespace Baekjoon1008
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            string[] ss = s.Split();
            double p = double.Parse(ss[0]);
            double q = double.Parse(ss[1]);
            Console.WriteLine(p/q);

        }
    }
}