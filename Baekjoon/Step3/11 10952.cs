using System;

namespace Baekjoon10952
{
    class Program
    {
        static void Main(string[] args)
        {
            while(true)
            {
                string[] ss = Console.ReadLine().Split();
                int a = int.Parse(ss[0]);
                int b = int.Parse(ss[1]);
                if (a+b == 0)
                {
                    break;
                }
                Console.WriteLine(a + b);

            }
        }
    }
}