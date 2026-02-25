using System;

namespace Op
{
    public class Komp
    {
        public double haq { get; set; }
        public double mav { get; set; }
        public Komp() { }
        public Komp(double Haq, double Mav) 
        {
            this.haq = Haq;
            this.mav = Mav;
        }

        public void chop()
        {
            char sim = mav > 0 ? '+' : (mav < 0 ? '-' : '0');
            string ch = (haq != 0 && sim != '0') ?
                string.Format($"{haq}{sim}{Math.Abs(mav)}i") :
                ((haq == 0 && sim != '0') ?
                string.Format($"{sim}{Math.Abs(mav)}i") :
                string.Format($"{haq}"));
            Console.WriteLine(ch);
        }
        public double KMod()
        {
            return Math.Sqrt(haq*haq+mav*mav);
        }
        public static Komp operator +(Komp k1, Komp k2)
        {
            Console.WriteLine("\nQo'shish:\n");
            Komp k = new Komp();
            k.haq=k1.haq+k2.haq;
            k.mav=k1.mav+k2.mav;
            return k;
        }
        public static Komp operator -(Komp k1, Komp k2)
        {
            Console.WriteLine("\nAyirish:\n");
            Komp k = new Komp();
            k.haq = k1.haq - k2.haq;
            k.mav = k1.mav - k2.mav;
            return k;
        }
        public static Komp operator *(Komp k1, Komp k2)
        {
            Console.WriteLine("\nKo'paytirish:\n");
            Komp k = new Komp();
            k.haq = k1.haq * k2.haq- k2.mav * k1.mav;
            k.mav = k1.haq * k2.mav+ k2.haq * k1.mav;
            return k;
        }
        public static Komp operator /(Komp k1, Komp k2)
        {
            Console.WriteLine("\nBo'lish:\n");
            Komp k = new Komp();
            double maxraj = k2.haq * k2.haq + k2.mav * k2.mav;
            k.haq = (k1.haq*k2.haq+k1.mav*k2.mav) / maxraj;
            k.mav = (k1.mav * k2.haq - k1.haq * k2.mav) / maxraj;
            return k;
        }
        public static bool operator >(Komp k1, Komp k2)
        {
            Console.WriteLine("\nKatta >:\n");
            return k1.KMod() > k2.KMod();
        }
        public static bool operator <(Komp k1, Komp k2)
        {
            Console.WriteLine("\nKichik <:\n");
            return k1.KMod() < k2.KMod();
        }
        public static bool operator ==(Komp k1, Komp k2)
        {
            Console.WriteLine("\nTeng ==:\n");
            return k1.KMod() == k2.KMod();
        }
        public static bool operator !=(Komp k1, Komp k2)
        {
            Console.WriteLine("\nTeng emas !=:\n");
            return k1.KMod() != k2.KMod();
        }
        public static Komp operator ++(Komp k)
        {
            Console.WriteLine("\nInkrement:\n");
            k.haq++;
            k.mav++;
            return k;
        }
        public static Komp operator --(Komp k)
        {
            Console.WriteLine("\nInkrement:\n");
            k.haq--;
            k.mav--;
            return k;
        }
        public static Komp operator !(Komp k)
        {
           Komp k1=new Komp();
            Console.WriteLine("\nTeskarisi:\n");
            k1.haq=1/k.haq;
            k1.mav=1/k.mav;
            return k1;
        }
        public static Komp operator ~(Komp k)
        {
            Komp k1 = new Komp();
            Console.WriteLine("\nQarama-qarshisi:\n");
            k1.haq = - k.haq;
            k1.mav = -k.mav;
            return k1;
        }
    }
}
