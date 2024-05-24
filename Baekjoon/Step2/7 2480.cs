using System;

namespace Baekjoon2480
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] ss = Console.ReadLine().Split();
            int a = int.Parse(ss[0]);
            int b = int.Parse(ss[1]);
            int c = int.Parse(ss[2]);
            if (a == b && b == c)
            {
                Console.WriteLine(10000 + a * 1000);
            }
            else if (a == b && b != c)
            {
                Console.WriteLine(1000 + a * 100);
            }
            else if (b == c && c != a)
            {
                Console.WriteLine(1000 + b * 100);
            }
            else if (c == a && a != b)
            {
                Console.WriteLine(1000 + c * 100);
            }
            else if (a != b &&  b != c && c != a)
            {
                if (a > b && b > c) Console.WriteLine(a * 100);
                if (a > c && c > b) Console.WriteLine(a * 100);
                if (b > a && a > c) Console.WriteLine(b * 100);
                if (b > c && c > a) Console.WriteLine(b * 100);
                if (c > a && a > b) Console.WriteLine(c * 100);
                if (c > b && b > a) Console.WriteLine(c * 100);
            }
        }
    }
}