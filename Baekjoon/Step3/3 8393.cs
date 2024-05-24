using System;

namespace Baekjoon8393
{
    class Program
    {
        static void Main(string[] args)
        {
            int value = int.Parse(Console.ReadLine());
            int result = 0;
            for(int i = 1; i < value+1; i++)
            {
                result = result + i;
            }
            Console.WriteLine(result);
        }
    }
}