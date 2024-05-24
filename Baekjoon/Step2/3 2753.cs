using System;

namespace Baekjoon2753
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            if (a % 4 == 0)
            {
                if (a % 100 == 0)
                {
                    if (a % 400 == 0)
                    {
                        Console.WriteLine("1");
                    }
                    else
                    {
                        Console.WriteLine("0");
                    }
                }
                else
                {
                    Console.WriteLine("1");
                }
            }
            else
            {
                Console.WriteLine("0");
            }
        }
    }
}