using System;
using System.IO;

namespace ConsoleApp17
{
     class Program
    {
        static void Main(string[] args)
        {
            
            StreamWriter f = new StreamWriter("Test.txt");
            for(int i=65;i<=100;i++) 
            {                
                f.WriteLine(i);
            }
            StreamReader r = new StreamReader("D:\\User\\Docs\\Projects\\ConsoleApp17\\ConsoleApp17\\Test2.txt");
            for (int i = 1; i <= 20; i++)
            {
              Console.Write(r.ReadLine()+" ");
            }
            f.Close();
        }
    }
}
