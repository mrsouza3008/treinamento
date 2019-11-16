using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mercadinho
{
    public class ClassEstoque
    {
        public int Id { get; set; }

        
        //public int IdDoProduto { get; set; }
        public  ClassProduto Produto { get; set; } // Link de Relacionamento

        public string NomeDoProduto => Produto.DescricaoDoProduto;
        public decimal QtdeEstoque { get; set; }
        public decimal QtdeMinimoEstoque { get; set; }
        public char Ativo { get; set;} 

        
    }
}
