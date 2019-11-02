using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mercadinho
{
    public class RepositoryProduto
    {
        public MercadinhoContext Context { get; set; }

        public RepositoryProduto()
        {
            Context = new MercadinhoContext();
        }

        public void Inserir(ClassProduto produto)
        {
            Context.Produtos_DB.Add(produto);
            Context.SaveChanges();
        }

        public ClassProduto Obter(int id)
        {
            return Context.Produtos_DB.Where(a => a.Id == id).FirstOrDefault();
        }

        public IEnumerable<ClassProduto> Obter() // Lista
        {
            return Context.Produtos_DB.ToList();
        }

        public void Editar(ClassProduto produto)
        {
            ClassProduto ProdutoNoDB = Obter(produto.Id);

            if (ProdutoNoDB != null)
            {
                Context.Entry(ProdutoNoDB).CurrentValues.SetValues(produto);
                Context.SaveChanges();
            }
        }

        public void Apagar(int id)
        {
            ClassProduto ProdutoNoDB = Obter(id);

            if (ProdutoNoDB != null)
            {
                Context.Produtos_DB.Remove(ProdutoNoDB);
                Context.SaveChanges();
            }
        }
    }
}
