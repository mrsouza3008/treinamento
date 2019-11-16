using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mercadinho
{
    public class RepositoryCompra
    {
        public MercadinhoContext Context { get; set; }

        public RepositoryCompra()
        {
            Context = new MercadinhoContext();
        }

        public void Inserir(ClassCompra compra)
        {
            Context.Compras_DB.Add(compra);
            Context.SaveChanges();
        }

        public ClassCompra Obter(int id)
        {
            return Context.Compras_DB.Where(a => a.Id == id).FirstOrDefault();
        }

        public IEnumerable<ClassCompra> Obter() // Lista
        {
            return Context.Compras_DB.ToList();
        }

        public void Editar(ClassCompra compra)
        {
            ClassCompra CompraNoDB = Obter(compra.Id);

            if (CompraNoDB != null)
            {
                Context.Entry(CompraNoDB).CurrentValues.SetValues(compra);
                Context.SaveChanges();
            }
        }

        public void Apagar(int id)
        {
            ClassCompra CompraNoDB = Obter(id);

            if (CompraNoDB != null)
            {
                Context.Compras_DB.Remove(CompraNoDB);
                Context.SaveChanges();
            }
        }

     

    }
}
