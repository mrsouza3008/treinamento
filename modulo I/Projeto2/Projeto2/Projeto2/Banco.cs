using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto2
{
    public class Banco
    {
        public int Id { get; set; }
        public int CodigoDoBanco { get; set; }
        public string NomeDoBanco { get; set; }

        public virtual ICollection<Conta> Contas { get; set; }

    }
}
