﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fundamentos
{
    public class Funcionario : Pessoa
    {
        public string Cargo { get; set; }
        public double Salario { get; set; }

        public void ApresentarSe()
        {
            Console.WriteLine("Olá, meu nome é " + this.Nome
                + ", tenho " + this.Idade + ", sou " + this.Cargo
                + " e meu salario é R$ " + this.Salario.ToString("f2") + ".");
        }

    }
}
