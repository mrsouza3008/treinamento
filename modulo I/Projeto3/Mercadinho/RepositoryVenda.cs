using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mercadinho
{
    public class RepositoryVenda
    {
        public MercadinhoContext Context { get; set; }

        public RepositoryVenda()
        {
            Context = new MercadinhoContext();
        }

        public void Inserir(ClassVenda venda)
        {
            Context.Vendas_DB.Add(venda);
            Context.SaveChanges();
        }

        public ClassVenda Obter(int id)
        {
            return Context.Vendas_DB.Where(a => a.Id == id).FirstOrDefault();
        }

        public IEnumerable<ClassVenda> Obter() // Lista
        {
            return Context.Vendas_DB.ToList();
        }

        public void Editar(ClassVenda venda)
        {
            ClassVenda VendaNoDB = Obter(venda.Id);

            if (VendaNoDB != null)
            {
                Context.Entry(VendaNoDB).CurrentValues.SetValues(venda);
                Context.SaveChanges();
            }
        }

        public void Apagar(int id)
        {
            ClassVenda VendaNoDB = Obter(id);

            if (VendaNoDB != null)
            {
                Context.Vendas_DB.Remove(VendaNoDB);
                Context.SaveChanges();
            }
        }
    }
}
