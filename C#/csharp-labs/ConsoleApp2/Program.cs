using System;

namespace ConsoleApp2
{
     class Program
    {
        static void Main(string[] args)
        {
            int n,asr;
            while (true)
            {
                Console.WriteLine("n=");
                n = Convert.ToInt32(Console.ReadLine());
                asr = (n - 1) / 100 + 1;
                Console.WriteLine("{0}-yil {1} asrning yili hisoblanadi", n, asr);
            }
        }
    }
}
