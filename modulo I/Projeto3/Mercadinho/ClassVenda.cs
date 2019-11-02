using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mercadinho
{
    public class ClassVenda
    {
        public int Id { get; set; }
        public int IdDoCliente { get; set; }
        public virtual ClassCliente Cliente { get; set; } // Link de Relacionamento
        public int IdDoProduto { get; set; }
        public virtual ClassProduto Produto { get; set; } // Link de Relacionamento
        public decimal QtdeVendida { get; set; }



    }
}
