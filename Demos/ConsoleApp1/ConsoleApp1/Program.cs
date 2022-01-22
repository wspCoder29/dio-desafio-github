using System;
using static System.Console;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            //Testando Reference Types

            Pessoa p1 = new Pessoa();
            p1.Nome = "Sonic";
            p1.Idade = 30;
            p1.Documento = "432";

            WriteLine($"Nome inicial: {p1.Nome}");

            Pessoa.AlterarNome(p1,"Knucles");

            WriteLine($"Nome inicial: {p1.Nome}");





        }
    }
}
