using System;

namespace ConsoleApp11
{
    class a
    {
        public int yi=1;
        public int yil
            {
            get { return yi; }
            set
            {
                if (value < 0) throw new ArgumentException("Xato qiymat");
               else this.yi = value;
            }
            }
       public void chop()
        {
            Console.WriteLine($"yil={yi}");
        }
}
    internal class Program
    {
        static void Main(string[] args)
        {
            a a2 = new a();
            a2.yil = 0;
             a2.chop();

            a b=new a();    
            b.yil = -2; 
            b.chop();   
        }
    }
}
