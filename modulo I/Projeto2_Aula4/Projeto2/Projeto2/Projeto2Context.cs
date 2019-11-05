using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto2
{
    public class Projeto2Context : DbContext  // herança, o Project2Context herda do DbContex Entity
    {
       // public Projeto2Context() : base("Server=DS03\\SQLEXPRESS;Database=AULA;User Id=sa;Password = Manager1;") // conexao será a string do bd
        public Projeto2Context() : base("conexao") // conexao será a string do bd
        {
        }
        public DbSet<Conta> Contas { get; set; } // cria a tabela
        public DbSet<Cliente> Clientes { get; set; } // cria a tabela
        public DbSet<Banco> Bancos { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)  // modo que vai criar - buscar a classe da ContaMap.cs
        {
            
            modelBuilder.Properties<string>().Configure(p => p.HasColumnType("varchar")); // Quando a propriedade for String configura como VARCHAR

            modelBuilder.Configurations.Add(new BancoMap()); // Configuração da tabela TAB_BANCO
            modelBuilder.Configurations.Add(new ContaMap());  // Configuração da tabela TAB_CONTA
            modelBuilder.Configurations.Add(new ClienteMap());  // Configuração da tabela TAB_CLIENTE

            modelBuilder.Entity<Conta>()
                        .HasRequired<Cliente>(c => c.Cliente)
                        .WithMany(a => a.Contas)
                        .HasForeignKey<int>(c => c.ClientId);

            modelBuilder.Entity<Conta>()
                        .HasRequired<Banco>(d => d.Banco)
                        .WithMany(e => e.Contas)
                        .HasForeignKey<int>(f => f.BancoId);

            base.OnModelCreating(modelBuilder);
        }
    }

  
}
