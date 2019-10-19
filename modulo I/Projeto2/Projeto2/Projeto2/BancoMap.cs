using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto2
{
    public class BancoMap : EntityTypeConfiguration<Banco>
    {
        public BancoMap()
        {
            ToTable("TAB_BANCO");

            HasKey(p => p.Id);
            Property(p => p.CodigoDoBanco).IsRequired();
            Property(p => p.NomeDoBanco).IsRequired().HasMaxLength(60);
    
        }
    }
}
