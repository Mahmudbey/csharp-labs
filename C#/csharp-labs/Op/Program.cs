using System;

namespace Op
{
    internal class Program
    {
        static void Main(string[] args)
        {            
            Console.Title = "Kompleks sonlar";
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Komp k1 = new Komp(2,5);
            Komp k2 = new Komp(8, 10);
            k1.chop();
            k2.chop();
            k1.KMod();
            k2.KMod();
            Komp k3 = new Komp();
            k3 = k1 + k2;
            k3.chop();
            k3 = k1 - k2;
            k3.chop();
            k3 = k1 * k2;
            k3.chop();
            k3 = k1 / k2;
            k3.chop();
            bool b;
            b = k1 > k2;
            Console.WriteLine(b);
            b = k1 < k2;
            Console.WriteLine(b);
            b = k1 == k2;
            Console.WriteLine(b);
            b = k1 != k2;
            Console.WriteLine(b);
        }
    }
}
