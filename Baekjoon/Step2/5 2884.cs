using System;

namespace Baekjoon2884
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            string[] ss = s.Split();
            int h = int.Parse(ss[0]);
            int m = int.Parse(ss[1]);
            int H,M,mc;
            if (m-45 >= 0)
            {
                H = h;
                M = m-45;
            }
            else
            {
                switch(h)
                {
                    case 0:
                        H = 23;
                        break;
                    default:
                        H = h-1;
                        break;
                }
                mc = m-45;
                M = 60+mc;
            }
            Console.WriteLine(H + " " + M);
        }
    }
}