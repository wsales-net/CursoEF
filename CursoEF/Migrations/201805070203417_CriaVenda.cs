namespace CursoEF.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CriaVenda : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Vendas",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ClienteId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Usuarios", t => t.ClienteId, cascadeDelete: true)
                .Index(t => t.ClienteId);
            
            CreateTable(
                "dbo.Venda_Produtos",
                c => new
                    {
                        VendaId = c.Int(nullable: false),
                        ProdutoId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.VendaId, t.ProdutoId })
                .ForeignKey("dbo.Vendas", t => t.VendaId, cascadeDelete: true)
                .ForeignKey("dbo.Produtoes", t => t.ProdutoId, cascadeDelete: true)
                .Index(t => t.VendaId)
                .Index(t => t.ProdutoId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Venda_Produtos", "ProdutoId", "dbo.Produtoes");
            DropForeignKey("dbo.Venda_Produtos", "VendaId", "dbo.Vendas");
            DropForeignKey("dbo.Vendas", "ClienteId", "dbo.Usuarios");
            DropIndex("dbo.Venda_Produtos", new[] { "ProdutoId" });
            DropIndex("dbo.Venda_Produtos", new[] { "VendaId" });
            DropIndex("dbo.Vendas", new[] { "ClienteId" });
            DropTable("dbo.Venda_Produtos");
            DropTable("dbo.Vendas");
        }
    }
}
