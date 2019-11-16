namespace Mercadinho.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CorrecadoContexto : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.ClassCompras", newName: "COMPRAS");
            RenameTable(name: "dbo.ClassFornecedors", newName: "FORNECEDORES");
            AlterColumn("dbo.FORNECEDORES", "NomeDoFornecedor", c => c.String(nullable: false, maxLength: 80, unicode: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.FORNECEDORES", "NomeDoFornecedor", c => c.String(maxLength: 8000, unicode: false));
            RenameTable(name: "dbo.FORNECEDORES", newName: "ClassFornecedors");
            RenameTable(name: "dbo.COMPRAS", newName: "ClassCompras");
        }
    }
}
