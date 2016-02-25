namespace Habilitations.Migrations
{
    using Habilitations.Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Habilitations.Models.AppDBContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "Habilitations.Models.AppDBContext";
        }

        protected override void Seed(Habilitations.Models.AppDBContext context)
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
            
            context.Categories.AddOrUpdate(
                c => c.Nom,
                new Categorie { ID = 1, Nom = "Achats"},
                new Categorie { ID = 2, Nom = "Commerce"},
                new Categorie { ID = 3, Nom = "Ressources Humaines"},
                new Categorie { ID = 4, Nom = "Conseil"},
                new Categorie { ID = 5, Nom = "IT"},
                new Categorie { ID = 6, Nom = "Communication/Media"}
            );

            context.Metiers.AddOrUpdate(
                m => m.Nom,
                new Metier { ID = 1, Nom = "Acheteur", CategorieId = 1 },
                new Metier { ID = 2, Nom = "Directeur des achats", CategorieId = 1 },
                new Metier { ID = 3, Nom = "Assistant(e) commercial", CategorieId = 2 },
                new Metier { ID = 4, Nom = "Responsable de clientèle", CategorieId = 2 },
                new Metier { ID = 5, Nom = "Assistante(e) chargé de clientèle", CategorieId = 2 },
                new Metier { ID = 6, Nom = "Controleur de gestion", CategorieId = 2 },
                new Metier { ID = 7, Nom = "Responsable RH", CategorieId = 3 },
                new Metier { ID = 8, Nom = "Chargé(e) de recrutement", CategorieId = 3 },
                new Metier { ID = 9, Nom = "Directeur conseil", CategorieId = 4 },
                new Metier { ID = 10, Nom = "Directeur de développement", CategorieId = 4 },
                new Metier { ID = 11, Nom = "Développeur", CategorieId = 5 },
                new Metier { ID = 12, Nom = "Graphiste", CategorieId = 5 },
                new Metier { ID = 13, Nom = "Chef de projet web", CategorieId = 5 },
                new Metier { ID = 14, Nom = "Chef de projet digital", CategorieId = 6 },
                new Metier { ID = 15, Nom = "Chef de projet event", CategorieId = 6 },
                new Metier { ID = 16, Nom = "Chef de projet éditorial", CategorieId = 6 }
            );
        }
    }
}
