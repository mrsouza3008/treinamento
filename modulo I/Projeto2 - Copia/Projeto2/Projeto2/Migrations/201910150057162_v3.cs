namespace Projeto2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class v3 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.TAB_CLIENTE",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        NomeTitular = c.String(nullable: false, maxLength: 60, unicode: false),
                        Nascimento = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.TAB_CONTA", "ClientId", c => c.Int(nullable: false));
            CreateIndex("dbo.TAB_CONTA", "ClientId");
            AddForeignKey("dbo.TAB_CONTA", "ClientId", "dbo.TAB_CLIENTE", "Id", cascadeDelete: true);
            DropColumn("dbo.TAB_CONTA", "NomeTitular");
            DropColumn("dbo.TAB_CONTA", "Nascimento");
        }
        
        public override void Down()
        {
            AddColumn("dbo.TAB_CONTA", "Nascimento", c => c.DateTime(nullable: false));
            AddColumn("dbo.TAB_CONTA", "NomeTitular", c => c.String(nullable: false, maxLength: 60, unicode: false));
            DropForeignKey("dbo.TAB_CONTA", "ClientId", "dbo.TAB_CLIENTE");
            DropIndex("dbo.TAB_CONTA", new[] { "ClientId" });
            DropColumn("dbo.TAB_CONTA", "ClientId");
            DropTable("dbo.TAB_CLIENTE");
        }
    }
}
