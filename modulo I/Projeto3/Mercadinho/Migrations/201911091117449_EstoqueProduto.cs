namespace Mercadinho.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class EstoqueProduto : DbMigration
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
                .ForeignKey("dbo.PRODUTOS", t => t.IdDoProduto, cascadeDelete: true)
                .Index(t => t.IdDoCliente)
                .Index(t => t.IdDoProduto);
            
            CreateTable(
                "dbo.PRODUTOS",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        DescricaoDoProduto = c.String(nullable: false, maxLength: 80, unicode: false),
                        ValorDeCompra = c.Decimal(nullable: false, precision: 18, scale: 2),
                        PercentualDeLucro = c.Int(nullable: false),
                        Ativo = c.String(nullable: false, maxLength: 1, unicode: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.ClassCompras",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ProdutoId = c.Int(nullable: false),
                        FornecedorId = c.Int(nullable: false),
                        QtdeDeCompra = c.Int(nullable: false),
                        DataDeRecebimento = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.ClassFornecedors", t => t.FornecedorId, cascadeDelete: true)
                .ForeignKey("dbo.PRODUTOS", t => t.ProdutoId, cascadeDelete: true)
                .Index(t => t.ProdutoId)
                .Index(t => t.FornecedorId);
            
            CreateTable(
                "dbo.ClassFornecedors",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        NomeDoFornecedor = c.String(maxLength: 8000, unicode: false),
                        Ativo = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.ESTOQUE",
                c => new
                    {
                        Id = c.Int(nullable: false),
                        QtdeEstoque = c.Decimal(nullable: false, precision: 18, scale: 2),
                        QtdeMinimoEstoque = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.PRODUTOS", t => t.Id)
                .Index(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.VENDAS", "IdDoProduto", "dbo.PRODUTOS");
            DropForeignKey("dbo.ESTOQUE", "Id", "dbo.PRODUTOS");
            DropForeignKey("dbo.ClassCompras", "ProdutoId", "dbo.PRODUTOS");
            DropForeignKey("dbo.ClassCompras", "FornecedorId", "dbo.ClassFornecedors");
            DropForeignKey("dbo.VENDAS", "IdDoCliente", "dbo.CLIENTES");
            DropIndex("dbo.ESTOQUE", new[] { "Id" });
            DropIndex("dbo.ClassCompras", new[] { "FornecedorId" });
            DropIndex("dbo.ClassCompras", new[] { "ProdutoId" });
            DropIndex("dbo.VENDAS", new[] { "IdDoProduto" });
            DropIndex("dbo.VENDAS", new[] { "IdDoCliente" });
            DropTable("dbo.ESTOQUE");
            DropTable("dbo.ClassFornecedors");
            DropTable("dbo.ClassCompras");
            DropTable("dbo.PRODUTOS");
            DropTable("dbo.VENDAS");
            DropTable("dbo.CLIENTES");
        }
    }
}
