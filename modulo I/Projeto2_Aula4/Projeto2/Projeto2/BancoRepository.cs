using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto2
{
    public class BancoRepository
    {
        //C  - Create (insert)
        //R  - Read (select)
        //U  - Update (update)
        //D  - Delete (delete)
        public Projeto2Context Context { get; set; } //Cria a instancia do Context

        public BancoRepository()
        {
            Context = new Projeto2Context();
        }

        public void Inserir(Banco banco)
        {
            Context.Bancos.Add(banco);
            Context.SaveChanges();

        }
        public void Editar(Banco banco)
        {
          
            Banco bancoDB = Obter(banco.Id);

            if (bancoDB != null)
            {
                Context.Entry(bancoDB).CurrentValues.SetValues(banco);
                Context.SaveChanges();
            }

        }
        public void Apagar(int id)
        {
            Banco bancoDB = Obter(id);

            if (bancoDB != null)
            {
                Context.Bancos.Remove(bancoDB);
                Context.SaveChanges();

            }

        }
        public Banco Obter(int id)
        {
            return Context.Bancos.Where(x => x.Id == id).FirstOrDefault();   // Localiza o primeiro ou valor default  
        }
        public IEnumerable<Banco> Obter()   //Lista do Tipo Banco
        {
            return Context.Bancos.ToList();
        }

     
    }
}
