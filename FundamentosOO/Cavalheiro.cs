using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FundamentosOO
{
    public class Cavalheiro : Personagem
    {
        public override void apresentarSe()
        {
            Console.WriteLine(" Olá, eu sou o Cavalheiro " + this.Nome + " tenho " + this.Vida + "pontos de vida, Inteligencia: " + this.Inteligencia + ", Agilidade: " + this.Agilidade + "Força: " + this.Forca + ". Meu nível atual é: " + this.Nivel);
            Console.WriteLine("===========================================================");
        }




    }
}
