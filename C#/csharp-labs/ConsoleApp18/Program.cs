using System;
using static System.Math;
using static System.Console;

namespace ConsoleApp18
{
    class Program
    {
        static void Main(string[] args)
        {
            double x, y;
            while (true)
            {
                WriteLine("x_chap_chegarasi=");
                x = Convert.ToDouble(ReadLine());
                WriteLine("y_chap_chegarasi=");
                y = Convert.ToDouble(ReadLine());
                double hx, hy;
                hx = hy = 0.01;

                bool b = false;

                int N = 1000;
                int M = 500;
                double eps = 0.01;
                WriteLine("Iteratsiya boshlandi");

                for (int i = 0; i <= N; i++)
                {
                    x += i * hx;
                    for (int j = 0; j <= M; j++)
                    {
                        y += j * hy;

                        if (Abs(f1(x) - g1(y)) < eps && Abs(f2(x) - g2(y)) < eps)
                        {
                            WriteLine($"x={x}\ty={y}\niteratsiya: {i}");
                            b = true;
                            break;
                        }
                        if (j == M - 1) M = 501;
                    }
                    if (i == N - 1) N = 1001;
                    if (b) break;
                }
                if (b)
                    WriteLine("Yechildi");
                else WriteLine("Berilgan oraliqda yechim yo'q");
            }
        }
        static double f1(double x) { return Sin(x - 1); }
        static double g1(double y) { return 1.3-y;}
        static double f2(double x) { return x-0.8;}
        static double g2(double y) { return Sin(y + 1); }
    }
}
