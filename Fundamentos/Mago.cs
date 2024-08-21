using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fundamentos
{
    public class Mago : Personagem
    {
        public override void apresentarSe()
        {
            Console.WriteLine("Prazer em conhecer-te, meu nome é " + this.Nome + ", sou temido pela inteligência estratégica que é " + this.Inteligencia + " embora tenha uma força de " + this.Forca + " e tenho agilidade de " + this.Agilidade + ". Nível:" + this.Nivel + " Vida:" + this.Vida + "!!");
            Console.WriteLine("====================================================================================");
        }
    }
}
