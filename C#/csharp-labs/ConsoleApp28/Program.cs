using System;

namespace ConsoleApp28
{
    delegate void Salom();
    delegate int Amal(int a, int b);

    class Program
    {
        static void Main(string[] args)
        {
            string ism = "Aziz";
            Salom s1 = delegate ()
            {
                Console.WriteLine($"Salom {ism}!");
            };
            // s1();

            Amal a1 = delegate (int x, int y)
            {
                int s = x + y;
                Console.WriteLine($"{x}+{y}={s}");
                return s;
            };
            // Console.WriteLine(a1(4, 6));
            // a1(2, 5);

            Amal a2 = (int x, int y) =>
            {
                int s = x * y;
                Console.WriteLine($"{x}*{y}={s}");
                return s;
            };
            a2(3, 3);
            Amal a3 = (int a, int b) => a / b;
            Console.WriteLine(a3(8,5));
        }
    }
}
