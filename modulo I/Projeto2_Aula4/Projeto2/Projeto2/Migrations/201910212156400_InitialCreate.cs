namespace Projeto2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
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
            
            CreateTable(
                "dbo.TAB_CONTA",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        BancoId = c.Int(nullable: false),
                        Agencia = c.String(nullable: false, maxLength: 4, unicode: false),
                        ContaCorrente = c.String(nullable: false, maxLength: 10, unicode: false),
                        Saldo = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Limite = c.Decimal(nullable: false, precision: 18, scale: 2),
                        ClientId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.TAB_BANCO", t => t.BancoId, cascadeDelete: true)
                .ForeignKey("dbo.TAB_CLIENTE", t => t.ClientId, cascadeDelete: true)
                .Index(t => t.BancoId)
                .Index(t => t.ClientId);
            
            CreateTable(
                "dbo.TAB_CLIENTE",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        NomeTitular = c.String(nullable: false, maxLength: 60, unicode: false),
                        Nascimento = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.TAB_CONTA", "ClientId", "dbo.TAB_CLIENTE");
            DropForeignKey("dbo.TAB_CONTA", "BancoId", "dbo.TAB_BANCO");
            DropIndex("dbo.TAB_CONTA", new[] { "ClientId" });
            DropIndex("dbo.TAB_CONTA", new[] { "BancoId" });
            DropTable("dbo.TAB_CLIENTE");
            DropTable("dbo.TAB_CONTA");
            DropTable("dbo.TAB_BANCO");
        }
    }
}
