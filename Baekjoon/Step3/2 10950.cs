using System;

namespace Baekjoon10950
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            for (int i = 0; i < a; i++)
            {
                string[] ss = Console.ReadLine().Split();
                int num1 = int.Parse(ss[0]);
                int num2 = int.Parse(ss[1]);
                Console.WriteLine(num1+num2);
            }
        }
    }
}