using System;
using static System.Console;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {


            int[] v = {0,2,4,6,8};

            int[] v2 = new int[v.Length];


            for (int i = 0; i<v.Length;i++)
            {
                v2[i] = v[i] + 1;
            }

            Console.WriteLine("Pares");
            for (int i = 0; i<v.Length;i++)
            {
                Console.Write(v[i]+" ");
            }

            Console.WriteLine();

            Console.WriteLine("Ímpares");
            for (int i = 0; i < v.Length; i++)
            {
                Console.Write(v2[i] + " ");
            }






        }
    }
}
