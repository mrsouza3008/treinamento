namespace Mercadinho.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ProjetoMercadinhoInicial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.CLIENTES",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        NomeDoCliente = c.String(nullable: false, maxLength: 60, unicode: false),
                        DataDeNascimento = c.DateTime(nullable: false),
                        DataDeUltimaCompra = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.VENDAS",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        IdDoCliente = c.Int(nullable: false),
                        IdDoProduto = c.Int(nullable: false),
                        QtdeVendida = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.CLIENTES", t => t.IdDoCliente, cascadeDelete: true)
                .ForeignKey("dbo.ClassProdutoes", t => t.IdDoProduto, cascadeDelete: true)
                .Index(t => t.IdDoCliente)
                .Index(t => t.IdDoProduto);
            
            CreateTable(
                "dbo.ClassProdutoes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        DescricaoDoProduto = c.String(maxLength: 8000, unicode: false),
                        EstoqueId = c.Int(nullable: false),
                        ValorDeCompra = c.Decimal(nullable: false, precision: 18, scale: 2),
                        PercentualDeLucro = c.Int(nullable: false),
                        QtdeEstoque = c.Decimal(nullable: false, precision: 18, scale: 2),
                        QtdeMinima = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.ESTOQUE", t => t.EstoqueId, cascadeDelete: true)
                .Index(t => t.EstoqueId);
            
            CreateTable(
                "dbo.ESTOQUE",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        IdDoProduto = c.Int(nullable: false),
                        QtdeEstoque = c.Decimal(nullable: false, precision: 18, scale: 2),
                        QtdeMinimoEstoque = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.VENDAS", "IdDoProduto", "dbo.ClassProdutoes");
            DropForeignKey("dbo.ClassProdutoes", "EstoqueId", "dbo.ESTOQUE");
            DropForeignKey("dbo.VENDAS", "IdDoCliente", "dbo.CLIENTES");
            DropIndex("dbo.ClassProdutoes", new[] { "EstoqueId" });
            DropIndex("dbo.VENDAS", new[] { "IdDoProduto" });
            DropIndex("dbo.VENDAS", new[] { "IdDoCliente" });
            DropTable("dbo.ESTOQUE");
            DropTable("dbo.ClassProdutoes");
            DropTable("dbo.VENDAS");
            DropTable("dbo.CLIENTES");
        }
    }
}
