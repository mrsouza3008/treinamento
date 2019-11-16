using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mercadinho
{
    public class TabelaBDFornecedor : EntityTypeConfiguration<ClassFornecedor>
    {
        public TabelaBDFornecedor()
        {
            ToTable("FORNECEDORES");

            HasKey(a => a.Id);

            Property(a => a.NomeDoFornecedor).IsRequired().HasMaxLength(80);
            Property(a => a.Ativo).IsRequired();
        }
    }
}
