using System;
using System.Runtime.InteropServices;
using System.Security.Principal;

namespace ConsoleApp10
{
    struct Kitob
    {
       public string nom;
       public string muallif;
       public string janr;
       public DateTime yil;
       public double narx;

       public Kitob(string N,string M,string j,DateTime d,double na)
        {
            this.nom = N;
            this.muallif = M;
            this.janr = j;
            this.yil = d;
            this.narx = na;

        }
       public  void chop()
        {
            Console.WriteLine($"\nNomi:\t{nom}\nMualllif:\t{muallif}\nJanr:\t{janr}\nYil:\t{yil}\n" +
                $"Narx\t{narx:0 so'm}\n");
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Kitob k = new Kitob();
            k.nom = "Martin Iden";k.muallif = "Jek London";
            k.yil = DateTime.Now;
            k.janr = "Badiiy";
            k.narx = 36000;
            k.chop();
            Kitob k2 = new Kitob("Abc","Test","A",DateTime.Parse("03/06/2023"),2020);
            k2.chop();
            Kitob k3 = Kitob();
            
        }
    }
}
