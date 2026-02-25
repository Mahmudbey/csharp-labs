using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AngouriMath;

namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {


        }
    }

    public static class Div
    {
        internal static string Latex(List<Entity> args)
            => @"\frac{" + args[0].Latexise() + "}{" + args[1].Latexise() + "}";
    }

}
