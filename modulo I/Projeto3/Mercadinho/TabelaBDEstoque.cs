using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mercadinho
{
    class TabelaBDEstoque : EntityTypeConfiguration<ClassEstoque>
    { 
        public TabelaBDEstoque()
        {
            ToTable("ESTOQUE");

            HasKey(a => a.Id);

           
            Property(a => a.QtdeEstoque);
            Property(a => a.QtdeMinimoEstoque);

            HasRequired(x => x.Produto).WithOptional(x => x.Estoque);

        }

    }
}
