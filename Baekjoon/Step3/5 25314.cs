using System;

namespace Baekjoon25314
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            for(int i = 0; i < a; i++)
            {
                Console.Write("long ");
                i = i + 3;
            }
            Console.Write("int");
            Console.WriteLine();
        }
    }
}