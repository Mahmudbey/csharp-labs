using System;

namespace ConsoleApp5
{
     class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("salom dunyo!\t davom ettirish");
            double a = 4;
            double b = 5;
            swap(ref a, ref b);
            Console.WriteLine("a={0}\tb={1}",a,b);
            kv(a, out double p,out double s);
            Console.WriteLine("a={0}\tp={1}\ts={2}",a,p,s);
        }
        static void swap(ref double a, ref double b)
        {
            double c;
            c = a;
            a = b;
            b = c;
        }
        static void kv(double a, out double per,out double s)
        {
            per = 4 * a;
            s = a * a;
        }
    }
}
