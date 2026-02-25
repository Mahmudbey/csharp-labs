using System;
using static System.Math;

namespace ConsoleApp6
{
     class Program
    {
        static double funksiya(int n)
        {
            double s = 1;
            for(int i=2;i<=n; i++)
            {
                s += i * (i - 1);
            }
            return Pow(Tan(s), n);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("(n>1)\tn=");
            int n = Int32.Parse(Console.ReadLine());
            Console.WriteLine("f({0})={1}",n,funksiya(n));
        }
    }
}
