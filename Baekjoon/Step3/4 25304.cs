using System;

namespace Baekjoon25304
{
    class Program
    {
        static void Main(string[] args)
        {
            int X = int.Parse(Console.ReadLine());
            int N = int.Parse(Console.ReadLine());
            int result = 0;
            for(int i = 0; i < N; i++)
            {
                string[] ss = Console.ReadLine().Split();
                int a = int.Parse(ss[0]);
                int b = int.Parse(ss[1]);
                result = result + (a * b);
            }
            if (X == result)
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }
        }
    }
}