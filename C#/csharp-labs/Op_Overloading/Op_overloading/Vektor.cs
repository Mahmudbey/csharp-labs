using System;

namespace Op_overloading
{
    class Vektor
    {
        public static int n = 10;
        //public double[] Vek { get; set; }
        public double[] Vek = new double[n];

        public Vektor() { }
        public Vektor(double[] vek)
        {
            //Vek = new double[n];
            Vek = vek;
        }
        public void chop()
        {
            foreach (double d in Vek)
            {
                Console.Write("{0}\t", d);
            }
            Console.WriteLine();
        }
        public double uzunlik()
        {
            double s = 0;
            foreach (double d in Vek)
            {
                s += Math.Pow(d, 2);
            }
            return Math.Sqrt(s);
        }

        // binar operatorlar +,-,*,/,>,<,>=,<=,!=,==
        public static Vektor operator +(Vektor v1, Vektor v2)
        {
            Console.WriteLine("+");
            Vektor v = new Vektor();
            for (int i = 0; i < n; i++)
            {
                v.Vek[i] = v1.Vek[i] + v2.Vek[i];
            }
            return v;
        }
        public static Vektor operator -(Vektor v1, Vektor v2)
        {
            Console.WriteLine("-");
            Vektor v = new Vektor();
            for (int i = 0; i < n; i++)
            {
                v.Vek[i] = v1.Vek[i] - v2.Vek[i];
            }
            return v;
        }
        public static double operator *(Vektor v1, Vektor v2)
        {
            Console.WriteLine("*");
            double s = 0;
            for (int i = 0; i < n; i++)
            {
                s += v1.Vek[i] * v2.Vek[i];
            }
            return s;
        }

        public static bool operator >(Vektor v1, Vektor v2)
        {
            Console.WriteLine(">");
            bool s = false;
            if (v1.uzunlik() > v2.uzunlik())
            {
                s = true;
            }
            return s;
        }
        public static bool operator <(Vektor v1, Vektor v2)
        {
            Console.WriteLine("<");
            bool s = false;
            if (v1.uzunlik() < v2.uzunlik())
            {
                s = true;
            }
            return s;
        }
        // unar operatorlar !, ++, --,~
        public static Vektor operator ~(Vektor v1)
        {
            Console.WriteLine("Skalyar songa ko'paytirish");
            Console.WriteLine("d=");
            double d = double.Parse(Console.ReadLine());
            Vektor v = new Vektor();
            for (int i = 0; i < n; i++)
            {
                v.Vek[i] = d * v1.Vek[i];
            }
            return v;
        }
        public static Vektor operator ++(Vektor v1)
        {
            Console.WriteLine("++");
            Vektor v = new Vektor();
            for (int i = 0; i < n; i++)
            {
                v.Vek[i] = v1.Vek[i]++;
            }
            return v;
        }
        public static Vektor operator --(Vektor v1)
        {
            Console.WriteLine("--");
            Vektor v = new Vektor();
            for (int i = 0; i < n; i++)
            {
                v.Vek[i] = v1.Vek[i]--;
            }
            return v;
        }
    }
}
