using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{

    class Pessoa
    {
        public string Nome { get; set; }
        public int Idade { get; set; }
        public string Documento { get; set; }

        public static void AlterarNome(Pessoa p, string novoNome)
        {
            p.Nome = novoNome;
        }








    }
}
