namespace Mercadinho.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class acertodetabelas : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.VENDAS", "ValorDaVenda", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AddColumn("dbo.VENDAS", "DataDaVenda", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.VENDAS", "DataDaVenda");
            DropColumn("dbo.VENDAS", "ValorDaVenda");
        }
    }
}
