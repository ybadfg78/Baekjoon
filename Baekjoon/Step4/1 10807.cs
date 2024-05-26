using System;

namespace Baekjoon10807
{
    class Program
    {
        static void Main(string[] args)
        {
            int t = int.Parse(Console.ReadLine());
            string[] ss = Console.ReadLine().Split();
            int k = int.Parse(Console.ReadLine());
            int result = 0;
            for (int i = 0; i < t; i++)
            {
                int s = int.Parse(ss[i]);
                if (s == k)
                {
                    result++;
                }
            }
            Console.WriteLine(result);
        }
    }
}