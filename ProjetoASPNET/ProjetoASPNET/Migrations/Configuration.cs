namespace ProjetoASPNET.Migrations
{
    using ProjetoASPNET.Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<ProjetoASPNET.Models.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(ProjetoASPNET.Models.ApplicationDbContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //
            /*context.Products.AddOrUpdate(
                p => p.Id,
                new Product
                {
                    Id = 1,
                    Nome = "produto 1",
                    Descricao = "descrição produto 1",
                    Color = "azul",
                    Modelo = "ford fiesta",
                    Codigo = "COD1",
                    Preco = 10
                },
                new Product
                {
                    Id = 2,
                    Nome = "produto 2",
                    Descricao = "descrição produto 1",
                    Color = "verde",
                    Modelo = "honda civic",
                    Codigo = "COD2",
                    Preco = 20
                },
                new Product
                {
                    Id = 3,
                    Nome = "produto 3",
                    Descricao = "descrição produto 1",
                    Color = "vemelho",
                    Modelo = "agile",
                    Codigo = "COD3",
                    Preco = 30
                }
                );*/
        }
    }
}
