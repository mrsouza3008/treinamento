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

        public ClassCliente Cliente { get; set; }
        public int IdDoProduto { get; set; }

        public string NomeDoCliente => Cliente?.NomeDoCliente ?? "";

        public ClassProduto Produto { get; set; }
        public string DescricaoDoProduto => Produto?.DescricaoDoProduto?? "";  
        
        public decimal QtdeVendida { get; set; }

        public decimal ValorDaVenda { get; set; }

        public DateTime DataDaVenda { get; set; }



    }
}
