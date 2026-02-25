using System;

namespace ConsoleApplication71
{
    class Program
    {
        static void Main(string[] args)
        {
            Kompleks k1 = new Kompleks(4,8);
            Kompleks k2 = new Kompleks(-6, 27);
            Kompleks k3 = new Kompleks(0, -52);
            Kompleks k4 = new Kompleks(35, 0);
            Kompleks k5 = new Kompleks(0, 0);

            Kompleks c1 = new Kompleks();

            k1.chop();
            k2.chop();

            c1.chop();
            c1 = k1 + k2;
            c1.chop();
            c1 = k1 - k2;
            c1.chop();
            c1 = k1 * k2;
            c1.chop();
            c1 = k1 / k2;
            c1.chop();

            c1 = !k1;
            c1.chop();
            c1 = k1++;
            c1.chop();

            bool b = k1 == k2;
            Console.WriteLine("b={0}",b);
            b = k1 != k2;
            Console.WriteLine("b={0}", b);
            b = k1 > k2;
            Console.WriteLine("b={0}", b);
            b = k1 < k2;
            Console.WriteLine("b={0}", b);
         
            //k3.chop();
            //k4.chop();
            //k5.chop();
        }
    }

    class Kompleks
    {
        public double haqiqiy;
        public double mavhum;

        public Kompleks() { }
        public Kompleks(double real, double imag)
        {
            this.haqiqiy = real;
            this.mavhum = imag;
        }
        public double KMod()
        {
            double z = haqiqiy * haqiqiy + mavhum * mavhum;
            return Math.Pow(z, 0.5);
        }
        public void chop()
        {
            char c = mavhum > 0 ? '+' : (mavhum < 0 ? '-' : '0');
            string s = string.Format("{0}{1}{2}i"
                , haqiqiy, c, Math.Abs(mavhum));
            if (haqiqiy != 0)
            {
                if (c != '0')
                {
                    Console.WriteLine(s);
                }
                else
                {
                    Console.WriteLine("{0}", haqiqiy);
                }
            }
            else
            {
                if (c != '0')
                {
                    Console.WriteLine("{0}i", mavhum);
                }
                else //if(c==0)
                {
                    Console.WriteLine("0");
                }
            }
        }
        //binar
        public static Kompleks operator +(Kompleks k1,
            Kompleks k2)
        {
            Console.WriteLine("+");
            Kompleks k = new Kompleks();
            k.haqiqiy = k1.haqiqiy + k2.haqiqiy;
            k.mavhum = k1.mavhum + k2.mavhum;
            return k;
        }
        public static Kompleks operator -(Kompleks k1,
            Kompleks k2)
        {
            Console.WriteLine("-");
            Kompleks k = new Kompleks();
            k.haqiqiy = k1.haqiqiy - k2.haqiqiy;
            k.mavhum = k1.mavhum - k2.mavhum;
            return k;
        }
        public static Kompleks operator *(Kompleks k1,
            Kompleks k2)
        {
            Console.WriteLine("*");
            Kompleks k = new Kompleks();
            k.haqiqiy = k1.haqiqiy * k2.haqiqiy - k1.mavhum * k2.mavhum;
            k.mavhum = k1.mavhum * k2.haqiqiy + k1.haqiqiy * k2.mavhum;
            return k;
        }
        public static Kompleks operator /(Kompleks k1,
            Kompleks k2)
        {
            Console.WriteLine("/");
            Kompleks k = new Kompleks();
            double maxraj = k2.KMod() * k2.KMod();
            k.haqiqiy = (k1.haqiqiy * k2.haqiqiy + k1.mavhum * k2.mavhum) / maxraj;
            k.mavhum = (k1.mavhum * k2.haqiqiy - k1.haqiqiy * k2.mavhum) / maxraj;
            return k;
        }
        //binar mantiqiy
        public static bool operator ==(Kompleks k1,
            Kompleks k2)
        {
            Console.WriteLine("==");
            return (k1.haqiqiy == k2.haqiqiy &&
                k1.mavhum == k2.mavhum);
        }
        public static bool operator !=(Kompleks k1,
            Kompleks k2)
        {
            Console.WriteLine("!=");
            return !(k1 == k2);
            //return !(k1.haqiqiy == k2.haqiqiy &&
            //    k1.mavhum == k2.mavhum);

        }
        public static bool operator >(Kompleks k1,
            Kompleks k2)
        {
            Console.WriteLine(">");
            return k1.KMod() > k2.KMod();
        }
        public static bool operator <(Kompleks k1,
            Kompleks k2)
        {
            Console.WriteLine("<");
            return k1.KMod() < k2.KMod();
        }
        //unar
        public static Kompleks operator !(Kompleks k1)
        {
            Console.WriteLine("!");
            Kompleks k = new Kompleks();
            k.haqiqiy = k1.haqiqiy;
            k.mavhum = -k1.mavhum;
            return k;
        }
        public static Kompleks operator ++(Kompleks k1)
        {
            Console.WriteLine("++");
            Kompleks k = new Kompleks();
            k.haqiqiy = k1.haqiqiy++;
            k.mavhum = k1.mavhum++;
            return k;
        }
    }
}
