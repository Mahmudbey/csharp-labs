using System;

namespace ConsoleApp7
{
     class Program
    {
        static void Main(string[] args)
        {
            Random r= new Random();
            Console.WriteLine("1-son");
            int a=Int32.Parse(Console.ReadLine());
            int b = 0;
            string s=a.ToString();
            Console.WriteLine("Qolgan sonlar tasodifiy bo'lsinmi ?\nHa uchun \"h\"ni bosing\nYo'q uchun \"y\"ni bosing");
            string kir=Console.ReadLine().ToLower();
            bool inp = !(kir=="h" || kir=="ha");
            if (inp)
            {
                for (int i = 1; i <= 9; i++)
                {
                    Console.WriteLine($"{i + 1}-son");
                    // b = r.Next(5, 100);
                    b = Int32.Parse(Console.ReadLine());
                    s += ", " + b.ToString();
                    // Console.Write($"{b}\t");
                    while (a > 0)
                    {
                        if (a > b)
                            a = a - b;
                        else if (a < b)
                            b = b - a;
                        else break;
                    }
                }
            }
            else
            {
                for (int i = 1; i <= 9; i++)
                {
                    Console.WriteLine($"\n{i + 1}-son");
                    b = r.Next(5, 100);
                    // b = Int32.Parse(Console.ReadLine());
                    s += ", " + b.ToString();
                    Console.Write($"{b}\t");
                    while (a > 0)
                    {
                        if (a > b)
                            a = a - b;
                        else if (a < b)
                            b = b - a;
                        else break;
                    }
                }
            }
            Console.WriteLine($"\n{s} sonlari uchun:\nEKUB={a}");
        }
    }
}
