namespace Mercadinho.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class alteracaocampoDatadeRecebimentoIntparaDate : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.ClassCompras", "DataDeRecebimento", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.ClassCompras", "DataDeRecebimento", c => c.Int(nullable: false));
        }
    }
}
