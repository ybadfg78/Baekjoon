using System;

namespace Baekjoon2525
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            string[] ss = s.Split();
            int h = int.Parse(ss[0]);
            int m = int.Parse(ss[1]);
            int t = int.Parse(Console.ReadLine());
            if (t >= 60)
            {
                int tm = t % 60;
                int th = t / 60;
                if (h + th >= 24)
                {
                    h = h + th - 24;
                }
                else
                {
                    h = h + th;
                }
                if (m + tm >= 60)
                {
                    if (h + th >= 24)
                    {
                        h = 0;
                    }
                    else
                    {
                        h = h + 1;
                    }
                    m = m + tm - 60;
                }
                else
                {
                    m = m + tm;
                }
                Console.WriteLine(h + " " + m);
            }
            else if (t < 60)
            {
                if (t+m >= 60)
                {
                    if (h + 1 >= 24)
                    {
                        h = 0;
                    }
                    else
                    {
                        h = h + 1;
                    }
                    m = m + t - 60;
                }
                else if (t+m < 60)
                {
                    m = m + t;
                }
                Console.WriteLine(h + " " + m);
            }
            
        }
    }
}