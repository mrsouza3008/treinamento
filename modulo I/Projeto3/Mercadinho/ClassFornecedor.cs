using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mercadinho
{
    public class ClassFornecedor
    {
        public int Id { get; set; }
        public string NomeDoFornecedor { get; set; }
        public bool Ativo { get; set; }
        public virtual ICollection<ClassCompra> Compras { get; set; }


    }
}
