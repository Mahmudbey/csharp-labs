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

namespace WindowsFormsApp4
{
    public partial class Form1 : Form
    {
        double t_T = 2;

       static int N = 50;
       static  int M = 40;

       static int nmax = 50;

        double d = 0;
        public Form1()
        {
            InitializeComponent();
        }
        double Xi(double m, double p, double k) 
        {
            return m * Pow((p + t_T), k);
        }

        double[] x = new double[N];
        double[] t = new double[M];
        double[,] xi = new double[N, M];
        double[,] f = new double[N, M];
        double[,] xi2 = new double[N, M];
        double[,] f2 = new double[N, M];
        double[,] u = new double[N, M];
        double[,] v = new double[N, M];
        double[,] u2 = new double[N, M];
        double[,] v2 = new double[N, M];

        int i = 0;
        int j = 0;
        private void Form1_Load(object sender, EventArgs e)
        {
            double a = 1;
            double a2 = a;

            double k = 1.0;
            double m = 2.3;
            double p = 2.1;
            double p2 = 2.02;


            double alfa = 1.0 / (1 - p);
            double beta = -alfa * (p - k * m) / (m + 1);
            double beta2 = -alfa * (p2 - k * m) / (m + 1);
            double g1 = 1 + 1.0 / m;
            double g2 = m / (m * k - 1);
            double A = Pow((Pow(Abs(beta), (1.0 / m)) / (k * g1 * g2)), g2);
            double A2 = Pow((Pow(Abs(beta2), (1.0 / m)) / (k * g1 * g2)), g2);
            //print(f"alf={alfa}\tbeta={beta}\tg1={g1}\tg2={g2}\tA={A}\tA2={A2}")


            double b1 = -1.0;
            double b2 = 1.0;
            double T = 1.0;
            double hx = (b2 - b1) * 1.0 / N;
            double ht = T * 1.0 / M;
            //print(f"hx={hx}\tht={ht}")

            for (i = 0; i < N; i++)
            {
                x[i] = b1 + hx * i;
            }
            for (j = 0; j < M; j++)
            {
                t[j] = j * ht;
            }
            for (i = 0; i < N; i++)
            {
                for (j = 0; j < M; j++)
                {
                    xi[i, j] = Xi(Abs(x[i]), t[j], -beta);
                }
            }

            for (i = 0; i < N; i++)
            {
                for (j = 0; j < M; j++)
                {
                    double f_f = a - Pow(xi[i, j], g1);
                    if (f_f <= 0)
                    {
                        f[i, j] = 0;
                    }
                    else
                    {
                        f[i, j] = A * Pow(f_f, g2);
                    }
                    f[i, j] = Xi(Abs(x[i]), t[j], -beta);
                }
            }

            for (i = 0; i < N; i++)
            {
                for (j = 0; j < M; j++)
                {
                    xi2[i, j] = Xi(Abs(x[i]), t[j], -beta2);
                }
            }

            for (i = 0; i < N; i++)
            {
                for (j = 0; j < M; j++)
                {
                    double f_f = a - Pow(xi[i, j], g1);
                    if (f_f <= 0)
                    {
                        f2[i, j] = 0;
                    }
                    else
                    {
                        f2[i, j] = A * Pow(f_f, g2);
                    }
                    f2[i, j] = Xi(Abs(x[i]), t[j], -beta);
                }
            }

            for (i = 0; i < N; i++)
            {
                for (j = 0; j < M; j++)
                {
                    u[i, j] = Pow((t_T + t[j]), alfa) * f[i, j];
                }
            }
            for (i = 0; i < N; i++)
            {
                for (j = 0; j < M; j++)
                {
                    v[i, j] = Pow((t_T + t[j]), alfa) * f2[i, j];
                }
            }

            double[,] Ku = new double[N - 1, M];
            double[,] Au = new double[N - 2, M];
            double[,] Bu = new double[N - 2, M];
            double[,] Cu = new double[N - 2, M];
            double[,] Fu = new double[N - 2, M];

            for (i = 0; i < N - 2; i++)
            {
                for (j = 0; j < M; j++)
                {
                    Ku[i, j] = Pow(k, m) * Pow(u[i, j], (m * (k - 1))) * Pow(Abs((u[i + 1, j] - u[i, j]) / hx), (m - 1));
                }
            }


            for (i = 0; i < N - 2; i++)
            {
                for (j = 0; j < M; j++)
                {
                    Au[i, j] = (ht / (hx * hx)) * Ku[i + 1, j];
                    Bu[i, j] = (ht / (hx * hx)) * Ku[i, j];
                    Cu[i, j] = Au[i, j] + Bu[i, j] + 1;
                    Fu[i, j] = -u[i, j ] - ht * Pow(u[i, j ], p);
                }
            }

            double[,] Yu = new double[N - 2, M];
            double[,] Ru = new double[N - 2, M];
            double[,] ru = new double[N - 2, M];

            for (j = 0; j < M; j++)
            {
                Yu[0, j] = 1;
                ru[0, j] = 0;
                Ru[0, j] = 1;
            }

            double maxraj = 1;
            double maxraj2 = 1;

            for (i = 1; i < N - 2; i++)
            {
                for (j = 1; j < M; j++)
                {
                    maxraj = Au[i, j] * ru[i - 1, j];
                    if (maxraj != 0)
                    {
                        ru[i, j] = (Cu[i, j] * ru[i - 1, j] - Bu[i, j]) / maxraj;
                        Ru[i, j] = (Bu[i, j] * Ru[i - 1, j] - Fu[i, j] * ru[i - 1, j]) / maxraj;
                        maxraj2 = maxraj;
                    }
                    else
                    {
                        maxraj = maxraj2;
                        ru[i, j] = (Cu[i, j] * ru[i - 1, j] - Bu[i, j]) / maxraj;
                        Ru[i, j] = (Bu[i, j] * Ru[i - 1, j] - Fu[i, j] * ru[i - 1, j]) / maxraj;
                    }
                }
            }


            for (i = 0; i < N - 3; i++)
            {
                for (j = 0; j < M; j++)
                {
                    Yu[i + 1, j] = ru[i, j] * Yu[i, j] + Ru[i, j];
                }
            }
        }

//def grafik(k, m, p, p2, a, a2):    
//    xpoints = np.array(x)
//    upoints = np.array(u)
//    vpoints = np.array(v)
//    plt.rcParams["figure.figsize"] = [10, 7]
//    plt.rcParams["figure.autolayout"] = True
//    fig, ax = plt.subplots()
//    ax.plot(x, upoints, label = 'u', color = 'blue')
//    ax.plot(x, vpoints, label = 'v', color = 'red')
//    ax.set_title('Cross-diffusion', size = 14)
//    #plt.legend()
//    plt.show()


//def grafik_u(k, m, p, p2, a, a2):    
//    xpoints = np.array(x)
//    upoints = np.array(u)
//    vpoints = np.array(v)
//    plt.rcParams["figure.figsize"] = [10, 7]
//    plt.rcParams["figure.autolayout"] = True
//    fig, ax = plt.subplots()
//    ax.plot(x, upoints, label = 'u', color = 'blue')
//    ax.set_title('Cross-diffusion', size = 14)
//    plt.show()


//def grafik_v(k, m, p, p2, a, a2):    
//    xpoints = np.array(x)
//    upoints = np.array(u)
//    vpoints = np.array(v)
//    plt.rcParams["figure.figsize"] = [10, 7]
//    plt.rcParams["figure.autolayout"] = True
//    fig, ax = plt.subplots()
//    ax.plot(x, vpoints, label = 'v', color = 'red')
//    ax.set_title('Cross-diffusion', size = 14)
//    plt.show()
        
        private void button1_Click(object sender, EventArgs e)
        {
            j = -1; d = -1;
            timer1.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            j = j + 1; d = d + 1;
            if (j > nmax - 1) timer1.Enabled = false;

            for (int i = 0; i < N; i++)
            {
                for (int kk = 0; kk < M; kk++)
                {
                    u2[i, kk] = u[j, nmax - i];
                }
            }
            for (int i = 0; i < N; i++)
            {
                for (int kk = 1; kk < M; kk++)
                {
                    u2[i, nmax + kk] = u2[i, nmax - kk];
                }
            }
            for (int i = 1; i < N; i++)
            {
                for (int kk = 0; kk < M; kk++)
                {
                    u2[nmax + i, kk] = u2[nmax - i, kk];
                }
            }
            axOpenGL1.RemoveSurfaces();
            axOpenGL1.AddSurface(u2);
        }
    }
}
