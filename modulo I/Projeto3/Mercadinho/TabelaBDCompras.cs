using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mercadinho
{
    public class TabelaBDCompras : EntityTypeConfiguration<ClassCompra>
    {
        public TabelaBDCompras()
        {
            ToTable("COMPRAS");

            HasKey(a => a.Id);

            Property(a => a.ProdutoId).IsRequired();
            Property(a => a.QtdeDeCompra).IsRequired();
            Property(a => a.DataDeRecebimento).IsRequired();
        }
    }
}
