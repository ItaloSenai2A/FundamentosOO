using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FundamentosOO
{
    public class Pessoa
    {
        public string Nome { get; set; }
        public int Idade { get; set; }

        public void Anos()
        {
            this.Idade += 5;
            Console.WriteLine("A idade Atual é " + this.Idade + " anos");
        }

    }
}
