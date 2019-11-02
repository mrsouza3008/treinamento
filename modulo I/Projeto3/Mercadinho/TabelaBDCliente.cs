using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration;

namespace Mercadinho
{
    class TabelaBDCliente : EntityTypeConfiguration<ClassCliente>
    {
        public TabelaBDCliente()
        {
            ToTable("CLIENTES");

            HasKey(a => a.Id);
            Property(a => a.NomeDoCliente).IsRequired().HasMaxLength(60);
            Property(a => a.DataDeNascimento).IsRequired();
           // Property(a => a.DataDeUltimaCompra);
            
        }
    }
}
