using System;
using System.CodeDom.Compiler;

namespace ConsoleApp23
{
    class sinf
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("CMD Worked!");
            double[,] arr = new double[10, 10];
            Random r=new Random();
            for(int i=0; i<arr.GetLength(0); i++)
            {
                for(int j=0; j<arr.GetLength(1);j++)
                {
                    arr[i,j] =r.Next(-10, 11);
                }
            }
            Print(arr);
            Print(Sort(arr));
            Console.Read();
        }
        static void Print(double[,] arr)
        {
            Console.WriteLine("\t###\t");
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    Console.Write(arr[i, j]+" ");
                }
                Console.WriteLine();
            }
            Console.WriteLine("\n***\n");
        }
        static double[,] Sort(double[,] arr)
        {
            double temp;
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1)-1; j++)
                {
                    if (arr[i,j] > arr[i, j + 1])
                    {
                        temp = arr[i, j];
                        arr[i, j] = arr[i, j + 1];
                        arr[i, j + 1] = temp;
                    }
                }                
            }
            return arr;
        }
    }
}
