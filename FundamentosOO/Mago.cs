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
            Console.WriteLine(" Olá, eu sou o Mago " + this.Nome + " tenho " + this.Vida + "pontos de vida");
        }

        public override void atacar()
        {
            Console.WriteLine();
        }

        public override void batalhar()
        {
            Console.WriteLine("");
        }

        public override void defender()
        {
            throw new NotImplementedException();
        }

        public override void evoluir()
        {
            throw new NotImplementedException();
        }
    }
}
