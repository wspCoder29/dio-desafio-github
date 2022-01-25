using Construtores.Models;
using System;

namespace Construtores
{
    class Program
    {

     public delegate void Operacao(int x, int y);

        static void Main(string[] args)
        {


            Matematica m = new Matematica(10, 20);
            m.Somar();



            /*
            Operacao op = new Operacao(Calculadora.Somar);
            op += Calculadora.Subtrair;
            op.Invoke(10,10);
            */

            /*
            Data data = new Data();
            //data.SetMes(2);

            data.Mes = 20;
            //Console.WriteLine(data.Mes);
            data.ApresentarMes();
            */

            /*
            Aluno p1 = new Aluno("Leandro", "Ferreira", "Teste");
            p1.Apresentar();
            */

            //  Pessoa p1 = new Pessoa("Leandro", "Ferreira");
            //  p1.Apresentar();

            /*
            Log log = Log.GetInstance();

            log.PropriedadeLog = "Teste Instancia";

            Log log2 = Log.GetInstance();
            Console.WriteLine(log2.PropriedadeLog);
            */





        }
    }
}
