using System;

namespace ConsoleApp8
{
    class yord
    {
        public static int EKUB(int a, int b)
        {
            while (a > 0)
            {
                if (a > b) a -= b;
                else if (b > a) b -= a;
                else break;
            }
            return a;
        }
        public static int EKUK(int a, int b)
        {
            return (a * b) / EKUB(a, b);
        }
        public static int EKUB_N(params int[] a)
        {
            int d = int.MaxValue;
            for (int i = 0; i < a.Length; i++)
            {
                for (int j = 0; j < a.Length; j++)
                {
                    if (j != i)
                    {
                        int f = EKUB(a[i], a[j]);
                        if (d > f)
                            d = f;
                    }
                }
            }
            return d;
        }
    }
}
