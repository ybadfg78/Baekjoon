using System;

namespace Baekjoon10871
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] ss2 = Console.ReadLine().Split();
            int t = int.Parse(ss2[0]);
            int k = int.Parse(ss2[1]);
            string[] ss = Console.ReadLine().Split();
            int result = 0;
            for (int i = 0; i < t; i++)
            {
                int s = int.Parse(ss[i]);
                if (s < k)
                {
                    Console.Write(s + " ");
                }
            }
            Console.WriteLine();
        }
    }
}