namespace Projeto2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class V2 : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.Contas", newName: "TAB_CONTA");
            AlterColumn("dbo.TAB_CONTA", "NomeTitular", c => c.String(nullable: false, maxLength: 60, unicode: false));
            AlterColumn("dbo.TAB_CONTA", "Banco", c => c.String(nullable: false, maxLength: 50, unicode: false));
            AlterColumn("dbo.TAB_CONTA", "Agencia", c => c.String(nullable: false, maxLength: 4, unicode: false));
            AlterColumn("dbo.TAB_CONTA", "ContaCorrente", c => c.String(nullable: false, maxLength: 10, unicode: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.TAB_CONTA", "ContaCorrente", c => c.String());
            AlterColumn("dbo.TAB_CONTA", "Agencia", c => c.String());
            AlterColumn("dbo.TAB_CONTA", "Banco", c => c.String());
            AlterColumn("dbo.TAB_CONTA", "NomeTitular", c => c.String());
            RenameTable(name: "dbo.TAB_CONTA", newName: "Contas");
        }
    }
}
