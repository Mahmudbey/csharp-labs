using System;

namespace ConsoleApp8
{
    class Program
    {
        //enum hafta { A=1,B,C,D}
        static void Main(string[] args)
        {
            int c = yord.EKUB(4, 18);
            int[] arr = new int[10] { 44, 4, 60, 8, 10, 12, 16, 18, 20, 24 };
            int d=yord.EKUB_N(arr);
            Console.WriteLine(d);
            //Random r=new Random();
            //hafta h = (hafta)r.Next(1,5);
            //Console.WriteLine(h);
        }
    }
}
