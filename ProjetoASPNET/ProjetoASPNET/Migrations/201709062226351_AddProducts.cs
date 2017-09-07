namespace ProjetoASPNET.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddProducts : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Products",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nome = c.String(nullable: false),
                        Descricao = c.String(),
                        Color = c.String(),
                        Modelo = c.String(nullable: false),
                        Codigo = c.String(nullable: false, maxLength: 4),
                        Preco = c.Single(nullable: false),
                        Peso = c.Single(nullable: false),
                        Altura = c.Single(nullable: false),
                        Largura = c.Single(nullable: false),
                        Comprimento = c.Single(nullable: false),
                        URLimagem = c.String(maxLength: 80),
                        Fabricado = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Products");
        }
    }
}
