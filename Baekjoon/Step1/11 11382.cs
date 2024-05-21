using System;

namespace Baekjoon11382
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();
            string[] ss = str.Split();
            long a, b, c;
            a = long.Parse(ss[0]);
            b = long.Parse(ss[1]);
            c = long.Parse(ss[2]);
            Console.WriteLine(a+b+c);

        }
    }
}