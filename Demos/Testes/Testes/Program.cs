using System;



namespace Testes
{
    class Program
    {
        static void Main(string[] args)
        {

            int x = 0;

            Console.Write("Indique até onde irá a contagem:");
            x = int.Parse(Console.ReadLine());

            Console.WriteLine("Usando For");
            for (int i = 0; i<=x;i++)
            {
                Console.Write(i+" ");
            }


            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Usando While");
            int y = 0;
            while (y<=x)
            {
                Console.Write(y + " ");
                y++;
            }

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Usando Do While");
            int z = 0;
            do {

                Console.Write(z + " ");
                z++;
            } while(z<=x);


            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Usando Vetor e foreach");
            int [] lista = {0,1,2,3,4,5,6,7,8,9,10};
            foreach (int numero in lista)
            {
                Console.Write(numero+ " ");
            }




        }
    }
}
