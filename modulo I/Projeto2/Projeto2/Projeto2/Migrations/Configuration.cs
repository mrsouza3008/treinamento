namespace Projeto2.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Projeto2.Projeto2Context>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(Projeto2.Projeto2Context context) //Inicializa dados do banco
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.

            _ = context.Clientes.Add(new Cliente()
            {
                NomeTitular = "Marcelo Souza",
                Nascimento = new DateTime(1978, 08, 30)

            });


            context.Contas.Add(new Conta()
            {
                Agencia = "0796",
                Banco = "Itau",
                Limite = 100,
                ContaCorrente = "60450-2",
                Saldo= 1000,
                ClientId = 1

            });
           
    
            
        }
    }
}
