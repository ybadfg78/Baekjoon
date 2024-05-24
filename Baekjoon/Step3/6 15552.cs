using System;
using System.Text;

namespace Baekjoon15552
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder();
            int l = int.Parse(Console.ReadLine());
            for (int i = 0; i < l; i++)
            {
                string[] ss = Console.ReadLine().Split();
                sb.Append(int.Parse(ss[0]) + int.Parse(ss[1]) + "\n");
            }
            Console.WriteLine(sb.ToString());
            
        }
    }
}