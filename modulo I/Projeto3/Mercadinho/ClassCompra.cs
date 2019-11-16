using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mercadinho
{
    public class ClassCompra
    {
        public int Id { get; set; }
        public int ProdutoId { get; set; }
        public ClassProduto Produto { get; set; }
        public string NomeDoProduto => Produto?.DescricaoDoProduto ?? "";
        public int FornecedorId { get; set; }
        public ClassFornecedor Fornecedor { get; set; }
        public string NomeDoFornecedor => Fornecedor?.NomeDoFornecedor ?? "";
        public int QtdeDeCompra { get; set; }
        public DateTime DataDeRecebimento { get; set; }

    }
}
