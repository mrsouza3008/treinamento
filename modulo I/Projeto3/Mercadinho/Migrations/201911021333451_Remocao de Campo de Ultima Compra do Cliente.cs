namespace Mercadinho.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RemocaodeCampodeUltimaCompradoCliente : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.CLIENTES", "DataDeUltimaCompra");
        }
        
        public override void Down()
        {
            AddColumn("dbo.CLIENTES", "DataDeUltimaCompra", c => c.DateTime(nullable: false));
        }
    }
}
