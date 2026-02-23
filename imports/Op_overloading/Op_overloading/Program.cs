using System;

namespace Op_overloading
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = Vektor.n;
            double[] mas = new double[N];
            mas = told(N);
            double[] mas2 = new double[N];
            mas2 = told2(N);

            Vektor v1 = new Vektor(mas);

            v1.chop();
            Vektor v2 = new Vektor(mas2);
            v2.chop();
            Vektor v = new Vektor();
            v.chop();
            v = v1 + v2;
            v.chop();
            v = v1 - v2;
            v.chop();
            double a = 0;
            a = v1 * v2;
            Console.WriteLine(a);
            //v = ~v1;
            //v.chop();
            v = v1++;
            v.chop();
            v = v2--;
            v.chop();
            bool b = false;
            Console.WriteLine(v1.uzunlik());
            Console.WriteLine(v2.uzunlik());
            b = v1 > v2;
            Console.WriteLine(b);
            b = v1 < v2;
            Console.WriteLine(b);
        }
        static double[] told(int n)
        {
            Random r = new Random();
            double[] arr = new double[n];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = r.Next(-3, 4);
            }
            return arr;
        }
        static double[] told2(int n)
        {
            Random r = new Random();
            double[] arr = new double[n];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = r.Next(-5, 6);
            }
            return arr;
        }
    }

}
