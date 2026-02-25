using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Math;
namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void Form1_Load(object sender, EventArgs e)
        {

            double a = 1;
            double a2 = a;
            double k = 1.2;
            double m = 2.1;
            double p = 2.1;
            double p2 = 2.02;
            double alfa = 1.0 / (1 - p);
            double beta = -alfa * (p - k * m) / (m + 1);
            double beta2 = -alfa * (p2 - k * m) / (m + 1);
            double g1 = 1 + 1.0 / m;
            double g2 = m / (m * k - 1);
            double A = Pow((Abs(Pow(Abs(beta), (1.0 / m)) / (k * g1 * g2))), g2);
            double A2 = Pow((Abs(Pow(Abs(beta2), (1.0 / m)) / (k * g1 * g2))), g2);
            //print(f"alf={alfa}\tbeta={beta}\tg1={g1}\tg2={g2}\tA={A}\tA2={A2}")
            double t_T = 2;
            int N = 100;
            int M = N;
            double b1 = -1.0;
            double b2 = 1.0;
            double T = 1.0;
            double hx = (b2 - b1) * 1.0 / N;
            double ht = T * 1.0 / M;

            double[] x = new double[N];
            for (int i = 0; i < N; i++)
            {
                x[i] = b1 + hx * i;

            }
            double[] t = new double[N];
            for (int i = 0; i < N; i++)
            {
                t[i] = T / M;

            }
            double[] xi = new double[N];
            for (int i = 0; i < N; i++)
            {
                xi[i] = Abs(x[i]) * (Pow((t_T + t[i]), (-beta)));
            }


            double[] f = new double[N];
            for (int i = 0; i < N; i++)
            {
                double f_f = Pow(a, g1) - Pow(xi[i], g1);
                if (f_f < 0)
                {
                    f[i] = 0;
                }
                else
                {
                    f[i] = A * Pow(f_f, g2);
                }
            }

            double[] xi2 = new double[N];
            for (int i = 0; i < N; i++)
            {
                xi[i] = Abs(x[i]) * (Pow((t_T + t[i]), (-beta2)));
            }

            double[] f2 = new double[N];
            for (int i = 0; i < N; i++)
            {
                double f_f = Pow(a, g1) - Pow(xi2[i], g1);
                if (f_f < 0)
                {
                    f[i] = 0;
                }
                else
                {
                    f[i] = A * Pow(f_f, g2);
                }
            }

            double[] u = new double[N];
            for (int i = 0; i < N; i++)
            {
                u[i] = Pow((t_T + t[i]), alfa) * f[i];
            }
            double[] v = new double[N];
            for (int i = 0; i < N; i++)
            {
                v[i] = Pow((t_T + t[i]), alfa) * f2[i];
            }

           
                for (int j = 0; j < u.GetLength(0); j++)
                {
                    chart1.Series[0].Points.AddXY(x[j], u[j]);
                
            }
        }
    }
}
