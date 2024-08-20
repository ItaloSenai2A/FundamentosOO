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
            Console.WriteLine("Olá, eu sou o Elfo " + this.Nome + " tenho " + this.Vida + "pontos de vida");
        }

        public override void atacar()
        {
            throw new NotImplementedException();
        }

        public override void batalhar()
        {
            throw new NotImplementedException();
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
