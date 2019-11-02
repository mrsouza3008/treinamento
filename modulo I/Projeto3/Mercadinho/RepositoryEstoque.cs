using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mercadinho
{
    public class RepositoryEstoque
    {
        public MercadinhoContext Context { get; set; }

        public RepositoryEstoque()
        {
            Context = new MercadinhoContext();
        }

        public void Inserir(ClassEstoque estoque)
        {
            Context.Estoques_DB.Add(estoque);
            Context.SaveChanges();
        }

        public ClassEstoque Obter(int id)
        {
            return Context.Estoques_DB.Where(a => a.Id == id).FirstOrDefault();
        }

        public IEnumerable<ClassEstoque> Obter() // Lista
        {
            return Context.Estoques_DB.ToList();
        }

        public void Editar(ClassEstoque estoque)
        {
            ClassEstoque EstoqueNoDB = Obter(estoque.Id);

            if (EstoqueNoDB != null)
            {
                Context.Entry(EstoqueNoDB).CurrentValues.SetValues(estoque);
                Context.SaveChanges();
            }
        }

        public void Apagar(int id)
        {
            ClassEstoque EstoqueNoDB = Obter(id);

            if (EstoqueNoDB != null)
            {
                Context.Estoques_DB.Remove(EstoqueNoDB);
                Context.SaveChanges();
            }
        }

    }
}
