using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Construtores.Models
{
    public class Calculadora
    {

        //Delagate
        public delegate void DelegateCalculadora();

        //Evento
        public static event DelegateCalculadora EventoCalculadora;


        public static void Somar(int x, int y)
        {

            if (EventoCalculadora != null)
            {
                System.Console.WriteLine($"Adição: {x + y}");
                EventoCalculadora();
            }
            else
            {
                Console.WriteLine("Nenhum inscrito");
            }
            Console.WriteLine($"Adição: {x+y}");
        }

        public static void Subtrair(int x, int y)
        {
            Console.WriteLine($"Subtração: {x - y}");
        }





    }
}
