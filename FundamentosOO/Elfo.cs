using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FundamentosOO
{
    public class Elfo : Personagem
    {
        public override void apresentarSe()
        {
            Console.WriteLine(" Olá, eu sou um Elfo " + this.Nome + " Tenho " + this.Vida + "\n Pontos de vida,\n Inteligencia: " + this.Inteligencia + ",\n Agilidade: " + this.Agilidade + "\nForça: " + this.Forca + "\n Meu nível atual é: " + this.Nivel);
            Console.WriteLine("===========================================================");
        }




    }
}
