namespace CursoEF.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UmaTabelaPorClasse : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.PessoaJuridica",
                c => new
                    {
                        Id = c.Int(nullable: false),
                        CPF = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Usuarios", t => t.Id)
                .Index(t => t.Id);
            
            AddColumn("dbo.Usuarios", "CNPJ", c => c.String());
            AddColumn("dbo.Usuarios", "Discriminator", c => c.String(maxLength: 128));
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.PessoaJuridica", "Id", "dbo.Usuarios");
            DropIndex("dbo.PessoaJuridica", new[] { "Id" });
            DropColumn("dbo.Usuarios", "Discriminator");
            DropColumn("dbo.Usuarios", "CNPJ");
            DropTable("dbo.PessoaJuridica");
        }
    }
}
