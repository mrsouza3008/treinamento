using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mercadinho
{
    public class ClassCliente
    {
        public int Id { get; set; }
        public string NomeDoCliente { get; set; }
        public DateTime DataDeNascimento { get; set; }
        // public DateTime DataDeUltimaCompra { get; set; }

        // Um cliente terá uma coleção(vários) de Vendas
        public virtual ICollection<ClassVenda> Vendas { get; set; }

    }
}
