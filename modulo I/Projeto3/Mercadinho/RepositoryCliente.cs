using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mercadinho
{
    public class RepositoryCliente
    {
        public MercadinhoContext Context { get; set; } 

        public RepositoryCliente()
        {
            Context = new MercadinhoContext();
        }

        public void Inserir(ClassCliente cliente)
        {
            Context.Clientes_DB.Add(cliente);
            Context.SaveChanges();
        }
                       
        public ClassCliente Obter(int id)
        {
            return Context.Clientes_DB.Where(a => a.Id == id).FirstOrDefault();
        }

        public IEnumerable<ClassCliente> Obter() // Lista
        {
            return Context.Clientes_DB.ToList();
        }

        public void Editar(ClassCliente cliente)
        {
            ClassCliente ClienteNoDB = Obter(cliente.Id);

            if (ClienteNoDB != null)
            {
                Context.Entry(ClienteNoDB).CurrentValues.SetValues(cliente);
                Context.SaveChanges();
            }
        }

        public void Apagar(int id)
        {
            ClassCliente ClienteNoDB = Obter(id);

            if (ClienteNoDB != null)
            {
                Context.Clientes_DB.Remove(ClienteNoDB);
                Context.SaveChanges();
            }
        }

    }
}
