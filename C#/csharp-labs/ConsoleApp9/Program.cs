using System;

namespace ConsoleApp9
{
    enum Ona { Aziza,Gulnora,Sohiba,
    Mahliyo,Shahnoza,Hilola,Jamila,Lola};
    enum Ota { Aziz,Bobur,Sardor,Amir,
    Farrux,Mansur,Hamid,Temur};
     class Program
    {
        static bool avlod(String s1, String s2)
        {
            Random r=new Random();            
            Ona on1 = (Ona)r.Next(0, (int)Ona.Shahnoza +1);
            Ota ot1 = (Ota)r.Next(0, (int)Ota.Temur + 1);
            Ona on2 = (Ona)r.Next(0, (int)Ona.Shahnoza + 1);
            Ota ot2 = (Ota)r.Next(0, (int)Ota.Temur + 1);
            Console.WriteLine("{1} - {0}\n{3} - {2}",on1,ot1,on2,ot2);
            bool f = (on1==on2&ot1==ot2)?true:false;
            return f;
        }
        static void Main(string[] args)
        {
            bool b = false;
            while (!b)
            {
                b = avlod("", "");
                Console.WriteLine(b);
            }
        }
    }
}
