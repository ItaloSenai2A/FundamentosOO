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
            Console.WriteLine("Olá, eu sou o Cavalheiro " + this.Nome + " tenho " + this.Vida + "pontos de vida");
        }

        public override void atacar()
        {
            Console.WriteLine();
        }

        public override void batalhar()
        {
            Console.WriteLine();
        }

        public override void defender()
        {
            Console.WriteLine();
        }

        public override void evoluir()
        {
            Console.WriteLine();
        }
    }
}
