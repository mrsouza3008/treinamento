using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mercadinho
{
    public class ClassProduto
    {
        public int Id { get; set; }
        public string DescricaoDoProduto { get; set; }

        // relacionamento com a Estoque
       //     public int EstoqueId { get; set; } 
        public ClassEstoque Estoque { get; set; }

        public decimal ValorDeCompra { get; set; }
        public int PercentualDeLucro { get; set; }
        public string Ativo { get; set; }

        //  --------------    Parte da Classe Estoque que não estarei mais usando ------------------
        public decimal QtdeEstoque { get; set; }
        public decimal QtdeMinima { get; set; }
        // -------------------------------------------------------------

        // Um produto terá uma coleção(vários) de Vendas
        public virtual ICollection<ClassVenda> Vendas { get; set; }



       

    }
}
