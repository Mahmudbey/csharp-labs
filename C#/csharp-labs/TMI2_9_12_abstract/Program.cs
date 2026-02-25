using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TMI2_9_12_abstract
{
    class A
    {
        public string name { get; set; }
        public int age { get; set; }
        public string Metod1()
        {
            return "Metod1";
        }
        public  A(int k)
        {
            this.age = k;
            this.name = "Abstraksiya";            
        }
        public A()
        {
            Console.WriteLine("Konstruktor");
        }
        public virtual  void metod2()
        {
            Console.WriteLine("Metod2");
        }
        public virtual void metod3()
        {
            Console.WriteLine("Virtual");
        }
    }

     class B:A
    {
        public  string  Metod1()
        {
            return "Voris Metod1";
        }
        public B(int k)
        {
            this.age = 2*k;
            this.name = "Abstraksiya voris";
        }
        public override void metod2()
        {
            Console.WriteLine("Voris Metod2 abs");
        }
        public override void metod3()
        {
            Console.WriteLine("Voris Metod3 abs");
        }
    }

   abstract class shakl
    {
        public abstract string name { get; set; }
        public abstract double yuza();
        public abstract double peri();
        //public double hajm();
    }

    class kvadrat:shakl
    {
      public override string name { get=>name; set=>name= "hh"; }
        public double tomon { get; set; }
        public override double yuza()=> tomon * tomon;
        public override double peri() => 4*tomon;

    }
     class Program
    {
        static void Main(string[] args)
        {
            A a = new A();
           Console.WriteLine(a.Metod1());
            a.metod2();

            A a2= new A(43);
            Console.WriteLine(a2.Metod1());
            a2.metod2();
            Console.WriteLine(a2.age+";\t"+a2.name);
            
            B ob=new B(4);
            ob.metod2();
            ob.metod3();
        }
    }
}
