using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto2
{
    public class ContaRepository
    {
        //C  - Create (insert)
        //R  - Read (select)
        //U  - Update (update)
        //D  - Delete (delete)
        public Projeto2Context Context { get; set; } //Cria a instancia do Context

        public ContaRepository()
        {
            Context = new Projeto2Context();
        }

        public void Inserir(Conta conta)
        {
            Context.Contas.Add(conta);
            Context.SaveChanges();

        }
        public void Editar(Conta conta)
        {
            //Editar modelo 1
            Context.Entry<Conta>(conta).State = System.Data.Entity.EntityState.Modified;
            Context.SaveChanges();

            //Editar modelo 2
            Conta contaDB = Obter(conta.Id);

            if (contaDB != null)
            {
                Context.Entry(contaDB).CurrentValues.SetValues(conta);
                Context.SaveChanges();
            }

        }
        public void Apagar(int id)
        {
            Conta contaDB = Obter(id);

            if (contaDB != null)
            {
                Context.Contas.Remove(contaDB);
                Context.SaveChanges();

            }

        }
        public Conta Obter(int id)
        {
            return Context.Contas.Where(x=>x.Id == id).FirstOrDefault();   // Localiza o primeiro ou valor default  
        }
        public IEnumerable<Conta> Obter()   //Lista do Tipo Conta
        {      
            return Context.Contas.ToList();
        }

        public void RealizarSaque(Conta conta, decimal valor)
        {
           // Context.Database.ExecuteSqlCommand($"UPDATE TAB_CONTA SET saldo=({conta.Saldo.ToString().Replace(",",".")}-{valor} WHERE id={conta.Id}");
            Context.Database.ExecuteSqlCommand($"UPDATE TAB_CONTA SET saldo=saldo-{valor} WHERE id={conta.Id}");
        }

        public void RealizarDeposito(Conta conta, decimal valor)
        {
            Context.Database.ExecuteSqlCommand($"UPDATE TAB_CONTA SET saldo=saldo+{valor} WHERE id={conta.Id}");

        }
        public void RealizarTransferencia(Conta contaOrigem, Conta contaDestino, decimal valor)
        {
            // Saca Origem
            Context.Database.ExecuteSqlCommand($"UPDATE TAB_CONTA SET saldo=saldo-{valor} WHERE id={contaOrigem.Id}");
            //Credita Destino
            Context.Database.ExecuteSqlCommand($"UPDATE TAB_CONTA SET saldo=saldo+{valor} WHERE id={contaDestino.Id}");

        }
        public bool ExisteSaldo(int id, decimal valor)
        {
            using (Projeto2Context context = new Projeto2Context())
            {
                Conta conta = context.Contas.Where(a => a.Id == id).FirstOrDefault();

                return conta.Saldo >= valor ? true : false;
            }
        }

    }
}
