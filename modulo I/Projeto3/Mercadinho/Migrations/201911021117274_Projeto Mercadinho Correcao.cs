namespace Mercadinho.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ProjetoMercadinhoCorrecao : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.ClassProdutoes", newName: "PRODUTOS");
            AddColumn("dbo.PRODUTOS", "Ativo", c => c.String(nullable: false, maxLength: 1, unicode: false));
            AlterColumn("dbo.PRODUTOS", "DescricaoDoProduto", c => c.String(nullable: false, maxLength: 80, unicode: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.PRODUTOS", "DescricaoDoProduto", c => c.String(maxLength: 8000, unicode: false));
            DropColumn("dbo.PRODUTOS", "Ativo");
            RenameTable(name: "dbo.PRODUTOS", newName: "ClassProdutoes");
        }
    }
}
