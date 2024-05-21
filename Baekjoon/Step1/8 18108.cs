using System;

namespace Baekjoon18108
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            int year1 = Int32.Parse(s);
            int year2 = year1 - 543;
            Console.WriteLine(year2);

        }
    }
}