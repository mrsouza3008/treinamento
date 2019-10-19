using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto2
{
    public class ClienteMap : EntityTypeConfiguration<Cliente>
    {
        public ClienteMap()
        {
            ToTable("TAB_CLIENTE");

            HasKey(p => p.Id);
            Property(p => p.NomeTitular).IsRequired().HasMaxLength(60);
            Property(p => p.Nascimento).IsRequired();



        }


        
    }
}
