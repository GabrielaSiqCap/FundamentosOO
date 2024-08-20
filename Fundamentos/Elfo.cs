using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fundamentos
{
    public class Elfo : Personagem
    {
        public override void apresentarSe()
        {
            Console.WriteLine("Olá, eu sou o Elfo, meu nome é " + this.Nome + ", sou temido pela agilidade  que é " + this.Agilidade + " embora tenha uma força de " + this.Forca + " e tenho inteligência de " + this.Inteligencia + ". Nível:" + this.Nivel + " Vida:" + this.Vida + "!!");
            Console.WriteLine("====================================================================================");
        }
    }
}
