using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mercadinho
{
    public class MercadinhoContext : DbContext
    {
        public MercadinhoContext() : base("conexao")
        {

        }

        public DbSet<ClassCliente> Clientes_DB { get; set; }
        public DbSet<ClassProduto> Produtos_DB { get; set; }
        public DbSet<ClassEstoque> Estoques_DB { get; set; }
        public DbSet<ClassVenda> Vendas_DB { get; set; }
        public DbSet<ClassFornecedor> Fornecedor_DB {get; set;}
        public DbSet<ClassCompra> Compras_DB { get; set; }



        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {

            // Quando a propriedade for String configura como VARCHAR
            modelBuilder.Properties<string>().Configure(p => p.HasColumnType("varchar"));

            // Tabelas do Banco de Dados
            modelBuilder.Configurations.Add(new TabelaBDCliente());
            modelBuilder.Configurations.Add(new TabelaBDEstoque());
            modelBuilder.Configurations.Add(new TabelaBDVenda());
            modelBuilder.Configurations.Add(new TabelaBDProduto());
            

            // Relacionamento da ESTOQUE com PRODUTO
            /*
            modelBuilder.Entity<ClassEstoque>()
                        .HasRequired<ClassProduto>(a => a.Produto)
                        .WithMany
                        .HasForeignKey<int>(a => a.Id);
            */

            // Relacionamento da VENDA com  PRODUTO e CLIENTE 

            modelBuilder.Entity<ClassVenda>()
                        .HasRequired<ClassProduto>(a => a.Produto)
                        .WithMany(a => a.Vendas)
                        .HasForeignKey<int>(a => a.IdDoProduto);

            modelBuilder.Entity<ClassVenda>()
                        .HasRequired<ClassCliente>(a => a.Cliente)
                        .WithMany(a => a.Vendas)
                        .HasForeignKey<int>(a => a.IdDoCliente);

            modelBuilder.Entity<ClassCompra>()
                        .HasRequired<ClassProduto>(a => a.Produto)
                        .WithMany(a => a.Compras)
                        .HasForeignKey<int>(a => a.ProdutoId);

            modelBuilder.Entity<ClassCompra>()
                        .HasRequired<ClassFornecedor>(a => a.Fornecedor)
                        .WithMany(a => a.Compras)
                        .HasForeignKey<int>(a => a.FornecedorId);


            base.OnModelCreating(modelBuilder);

        }

    }
}
