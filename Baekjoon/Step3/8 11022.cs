using System;

namespace Baekjoon11022
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            for (int i = 1; i <= a; i++)
            {
                string[] ss = Console.ReadLine().Split();
                int num1 = int.Parse(ss[0]);
                int num2 = int.Parse(ss[1]);
                int num3 = num1 + num2;
                Console.WriteLine($"Case #{i}: {num1} + {num2} = {num3}");
            }
        }
    }
}