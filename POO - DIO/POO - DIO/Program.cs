using POO_DIO.src.Entities;

using System;


namespace POO_DIO
{
    class Program
    {
        static void Main(string[] args)
        {

            BlackWizard bMage = new BlackWizard("Ninwa", 7, "Black Mage");
            Console.WriteLine(bMage);
            Console.WriteLine(bMage.BlackStorm(7));
            Console.WriteLine(bMage.Catastrofe(12));

            Console.WriteLine();

            WhiteWizard wMage = new WhiteWizard("Aerith", 20, "White Mage");
            Console.WriteLine(wMage);
            Console.WriteLine(wMage);
            Console.WriteLine(wMage.HealingWind());
            Console.WriteLine(wMage.CureStatus());

            Console.WriteLine();
            Knight knight = new Knight("Cloud", 7,"Knight");
            Console.WriteLine(knight);
            Console.WriteLine(knight.PowerUp());
            Console.WriteLine(knight.OmniChange());

            Console.WriteLine();
            Ninja ninja = new Ninja("Haomaru", 8, "Ninja");
            Console.WriteLine(ninja);
            Console.WriteLine(ninja.Furtive());
            Console.WriteLine(ninja.NinjaWay());







        }
    }
}
