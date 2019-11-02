using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mercadinho
{
    class TabelaBDVenda : EntityTypeConfiguration<ClassVenda>
    {
        public TabelaBDVenda()
        {
            ToTable("VENDAS");

            HasKey(a => a.Id);

            Property(a => a.IdDoCliente).IsRequired();
            Property(a => a.IdDoProduto).IsRequired();
            Property(a => a.QtdeVendida).IsRequired();
            

        }
    
    }
}
