﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Construtores.Models
{
    class Aluno : Pessoa
    {

        public Aluno(string nome, string sobrenome, string disciplina) : base(nome, sobrenome) 
        {

            Console.WriteLine("Construtor classe Aluno");
        }



    }
}
