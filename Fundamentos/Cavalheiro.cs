using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fundamentos
{
    public class Cavalheiro : Personagem
    {
        public override void apresentarSe()
        {
            Console.WriteLine("Bom dia independente do horário, meu nome é " + this.Nome + ", sou temido pela grande força  que é " + this.Forca + " embora tenha uma inteligência de " + this.Inteligencia + " e tenho agilidade de " + this.Agilidade + ". Nível:" + this.Nivel + " Vida:" + this.Vida + "!!");
            Console.WriteLine("====================================================================================");
        }


    }
}

