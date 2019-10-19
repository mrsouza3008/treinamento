namespace Projeto2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CriacaoBanco : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.TAB_BANCO",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        CodigoDoBanco = c.Int(nullable: false),
                        NomeDoBanco = c.String(nullable: false, maxLength: 60, unicode: false),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.TAB_CONTA", "BancoId", c => c.Int(nullable: false));
            CreateIndex("dbo.TAB_CONTA", "BancoId");
            AddForeignKey("dbo.TAB_CONTA", "BancoId", "dbo.TAB_BANCO", "Id", cascadeDelete: true);
            DropColumn("dbo.TAB_CONTA", "Banco");
        }
        
        public override void Down()
        {
            AddColumn("dbo.TAB_CONTA", "Banco", c => c.String(nullable: false, maxLength: 50, unicode: false));
            DropForeignKey("dbo.TAB_CONTA", "BancoId", "dbo.TAB_BANCO");
            DropIndex("dbo.TAB_CONTA", new[] { "BancoId" });
            DropColumn("dbo.TAB_CONTA", "BancoId");
            DropTable("dbo.TAB_BANCO");
        }
    }
}
