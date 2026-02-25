using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp16
{
    class A
    {
       public string s;
        public A() { }
        public void met()
        {
            Console.WriteLine("ABC");
        }

    public    class B
        {
            public string s2;
            public B() { }
            public void met2()
            {
                Console.WriteLine("ACD");
            }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            A.B ob = new A.B();
            A ob2 = new A();
            ob.met2();
            ob2.met();
;        }
    }
}
