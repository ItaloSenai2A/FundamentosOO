using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FundamentosOO
{
    public class Mago : Personagem
    {
        public override void apresentarSe()
        {
            Console.WriteLine(" Olá, eu sou o Mago " + this.Nome + "\n Tenho " + this.Vida + "\n pontos de vida,\n Inteligencia: " + this.Inteligencia + "\n Agilidade: " + this.Agilidade + "\n Força: " + this.Forca + "\n Meu nível atual é: " + this.Nivel);
            Console.WriteLine("===========================================================");
        }



    }
}
