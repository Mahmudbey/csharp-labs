using System;
using System.Text;

namespace ConsoleApp13
{
    public class Program
    {
     public   static void Main(string[] args)
        {
            /*string ar = args[0];

            if(args[0] == "0")
                Console.WriteLine("Just");
            else if(args[0] == "1")
                Console.WriteLine("Hello");
            else if(args[0] == "test")
                Console.WriteLine("Test");
            else
                Console.WriteLine("C# salom");*/
            Console.WriteLine("Salomlar");

            tortb t = new tortb();
            t.Eni = 4 ;
            t.Boyi = 5;
            t.yuza();

            doira d=new doira();
            d.Eni = 2;
            d.Boyi = 10;
            d.yuza();
            d.Radius = 1;
            d.yuza();
            


        }
    }
    public class tortb
    {
        private double eni;
        private double boyi;
        public double Eni
        {
            get { return eni; }
            set
            {
                if (value > 0)
                {
                    eni = Eni;
                }
            }
        }
        public double Boyi
        {
            get { return boyi; }
            set
            {
                if (value > 0)
                {
                    boyi = Boyi;
                }
            }
        }
      internal  void yuza()
        {
            double s = eni * boyi;
            Console.WriteLine($"S={s}");
        }
    }
    class doira:tortb
    {
        private double radius;
        public double Radius
        {
            get { return radius; }
            set
            {
                if(value>0)
                {
                    radius = Radius;
                }
            }
        }
    }
}
