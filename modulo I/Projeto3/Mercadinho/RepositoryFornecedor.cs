using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mercadinho
{
    public class RepositoryFornecedor
    {
        public MercadinhoContext Context { get; set; }

        public RepositoryFornecedor()
        {
            Context = new MercadinhoContext();
        }

        public void Inserir(ClassFornecedor fornecedor)
        {
            Context.Fornecedor_DB.Add(fornecedor);
            Context.SaveChanges();
        }

        public ClassFornecedor Obter(int id)
        {
            return Context.Fornecedor_DB.Where(a => a.Id == id).FirstOrDefault();
        }

        public IEnumerable<ClassFornecedor> Obter() // Lista
        {
            return Context.Fornecedor_DB.ToList();
        }

        public void Editar(ClassFornecedor fornecedor)
        {
            ClassFornecedor FornecedorNoDB = Obter(fornecedor.Id);

            if (FornecedorNoDB != null)
            {
                Context.Entry(FornecedorNoDB).CurrentValues.SetValues(fornecedor);
                Context.SaveChanges();
            }
        }

        public void Apagar(int id)
        {
            ClassFornecedor FornecedorNoDB = Obter(id);

            if (FornecedorNoDB != null)
            {
                Context.Fornecedor_DB.Remove(FornecedorNoDB);
                Context.SaveChanges();
            }
        }

    }
}
