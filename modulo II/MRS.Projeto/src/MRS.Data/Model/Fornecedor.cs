using System.Collections.Generic;

namespace MRS.Data.Model
{
    public class Fornecedor : Entity
    {
        public string  Nome { get; set; }
        public string Documento { get; set; }
        public bool Ativo { get; set; }

        public IEnumerable<Produto> Produtos { get; set; }
    }
}