using System;

namespace ConsoleApp14
{
    partial class A
    {
        public void xabar()
        {
            Console.WriteLine("Maydon");
        }
        static void Main(string[] args)
        {
            A a=new A();
            a.xabar();
            a.xab();
            a.xaba();
        }
    }
    partial class A
    {
        public void xab()
        {
            Console.WriteLine("1-qism sinf");
        }
    }
    partial class A
    {
        public void xaba()
        {
            Console.WriteLine("2-qism sinf");
        }
    }
}
