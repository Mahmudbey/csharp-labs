using System;
using System.Collections;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //4.11-misol
            /*int n, m;
            while (true) { 
            Console.WriteLine("n=");
            n=Int32.Parse(Console.ReadLine());
            Console.WriteLine("m=");
            m = Int32.Parse(Console.ReadLine());

            double[,] massiv = new double[n, m];
            Random rnd = new Random();

            Console.WriteLine("Massiv:");
            for(int i=0;i<massiv.GetLength(0);i++)
            {
                for(int j=0;j<massiv.GetLength(1);j++)
                {
                        massiv[i, j] = rnd.Next(1, 15);
                        //massiv[i, j] = i + j-i*j+1;
                    Console.Write("\t" + massiv[i, j]);
                }
                Console.WriteLine();
            }
                double[] min = new double[n];
                double[] max = new double[m];
                for (int i = 0; i < massiv.GetLength(0); i++)
                {
                    min[i] = massiv[i,0];
                    for (int j = 0; j < massiv.GetLength(1); j++)
                    {
                        if (min[i] > massiv[i,j])
                        {
                            min[i] = massiv[i, j];
                        }
                    }
                }
                for (int j = 0; j < massiv.GetLength(1); j++)
                {
                    max[j] = massiv[0, j];
                    for (int i = 0; i < massiv.GetLength(0); i++)
                    {
                        if (max[j] < massiv[i, j])
                        {
                            max[j] = massiv[i, j];
                        }
                    }
                }
                for(int i=0;i<massiv.GetLength(0);i++)
                {
                    for(int j=0;j<massiv.GetLength(1);j++)
                    {
                        if (max[j] == min[i])
                        {
                            Console.WriteLine("element: "+min[i]);
                        }
                    }
                }
            }*/


            //4.26-misol
            /*
            int m = 8, n=10;
            double[] m1 = new double[m];
            double[] m2 = new double[n];
            ArrayList al = new ArrayList();
            Random rnd=new Random();
            Console.WriteLine("\n1-massiv:");
            for(int i = 0; i < m1.Length; i++)
            {
                m1[i] = rnd.Next(-100, 101);
                Console.Write("\t"+m1[i]);
            }
            Console.WriteLine("\n2-massiv:");
            for (int i = 0; i < m2.Length; i++)
            {
                m2[i] = rnd.Next(-100, 101);
                Console.Write("\t" + m2[i]);
            }
            Console.WriteLine();
            double k;
            for(int i=0;i<m1.Length;i++)
            {
                k = m1[i];
                for(int j=0;j<m2.Length;j++)
                {
                    if (k != m2[j])
                    {
                        al.Add(k);
                    }
                }
            }
            double min_k = Convert.ToDouble(al[0]);
            for(int i=1;i<al.Count;i++)
            {
                if (min_k > Convert.ToDouble(al[i]))
                {
                    min_k= Convert.ToDouble(al[i]);
                }
            }

            Console.WriteLine("So'ralgan element:\n{0}",min_k);
            */

            //3.26-misol
            /*
            while (true)
            {
                int n, m, k = 0;
                Console.WriteLine("n=");
                n = Int32.Parse(Console.ReadLine());
                m = n * n;
                while (m > 0)
                {
                    if (m % 10 == 3)
                    {
                        k++;
                    }
                    m = m / 10;
                }
                if (k > 0)
                {
                    Console.WriteLine("{0} sonida 3 raqami {1} marta uchraydi", n * n, k);
                }
                else Console.WriteLine("{0} sonida 3 raqami uchramaydi", n*n);
            }
            */



            //3.11
           /* int n;
            Console.WriteLine("n=");
            n = Int32.Parse(Console.ReadLine());

            int[] fakt = new int[2 * n];
            fakt[0] = 1;
            for (int i = 1; i < fakt.Length; i++)
            {
                fakt[i] = (i + 1) * fakt[i - 1];
            }
            double xn = 0.1;
            double xk = 1;
            double h = (xn - xk) / n;
            double[] x_mas = new double[n];
            for (int i = 0; i < x_mas.Length; i++)
            {
                x_mas[i] = xn + i * h;
            }

            double s = 0, s1 = 0, eps = 0.001, s2;
            for (int i = 0; i < n; i++)
            {
                s1 = s;
                s += Math.Pow(-1, i) * (2 * i * i + 1) *Math.Pow(x_mas[i],2*i) / (fakt[2 * i]);
                if (Math.Abs(s - s1) < eps)
                {
                    s2 = (1 - x_mas[i] * x_mas[i] / 2) * Math.Cos(x_mas[i]) - x_mas[i] / 2 * Math.Sin(x_mas[i]);
                    Console.WriteLine("\nAniq qiymat: {1}\nSonli hisoblash: {0}\naniq yechim bilan farq: {2}\niteratsiyadagi farq: {3}\ni={4}\n", s, s2, (s2 - s),(s-s1),i);

                }
            }*/
        }
    }
}
