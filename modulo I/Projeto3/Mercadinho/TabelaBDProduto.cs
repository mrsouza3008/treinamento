using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mercadinho
{
    class TabelaBDProduto : EntityTypeConfiguration<ClassProduto>
    {
        public TabelaBDProduto()
        {
            ToTable("PRODUTOS");

            HasKey(a => a.Id);

            Property(a => a.DescricaoDoProduto).IsRequired().HasMaxLength(80);
            Property(a => a.ValorDeCompra).IsRequired();
            Property(a => a.PercentualDeLucro).IsRequired();
            Property(a => a.Ativo).IsRequired().HasMaxLength(1);
            HasOptional(x => x.Estoque).WithRequired(x => x.Produto);
            //  --------------    Parte da Classe Estoque que não estarei mais usando ------------------
            // Property(a => a.QtdeEstoque);
            // Property(a => a.QtdeMinima);
            //-----------------------------------------------------------------------------------------
        }
    }
}
