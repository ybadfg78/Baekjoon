using System;

namespace Baekjoon2588
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());

            int b1 = b % 10;
            int b2 = (b / 10) % 10;
            int b3 = b / 100;
            
            Console.WriteLine(a * b1);
            Console.WriteLine(a * b2);
            Console.WriteLine(a * b3);
            Console.WriteLine(a * b);

        }
    }
}