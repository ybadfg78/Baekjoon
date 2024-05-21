using System;

namespace Baekjoon1000
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();
            string[] strs = str.Split();
            int a = int.Parse(strs[0]);
            int b = int.Parse(strs[1]);
            Console.WriteLine(a+b);
        }
    }
}