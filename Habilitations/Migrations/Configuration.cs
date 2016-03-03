using Habilitations.Models;

namespace Habilitations.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<AppDBContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(AppDBContext context)
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
              new Categorie { ID = 1, Nom = "Achats" },
              new Categorie { ID = 2, Nom = "Commerce" },
              new Categorie { ID = 3, Nom = "Ressources Humaines" },
              new Categorie { ID = 4, Nom = "Conseil" },
              new Categorie { ID = 5, Nom = "IT" },
              new Categorie { ID = 6, Nom = "Communication/Media" }
          );

            context.Metiers.AddOrUpdate(
                m => m.Nom,
                new Metier { ID = 1, Nom = "Acheteur", DebutValidite = DateTime.Parse("12/12/2015"), FinValidite = DateTime.Parse("12/12/2017"), CategorieId = 1 },
                new Metier { ID = 2, Nom = "Directeur des achats", DebutValidite = DateTime.Parse("12/12/2015"), FinValidite = DateTime.Parse("12/12/2017"), CategorieId = 1 },
                new Metier { ID = 3, Nom = "Assistant(e) commercial", DebutValidite = DateTime.Parse("12/12/2015"), FinValidite = DateTime.Parse("12/12/2017"), CategorieId = 2 },
                new Metier { ID = 4, Nom = "Responsable de clientèle", DebutValidite = DateTime.Parse("12/12/2015"), FinValidite = DateTime.Parse("12/12/2017"), CategorieId = 2 },
                new Metier { ID = 5, Nom = "Assistante(e) chargé de clientèle", DebutValidite = DateTime.Parse("12/12/2015"), FinValidite = DateTime.Parse("12/12/2017"), CategorieId = 2 },
                new Metier { ID = 6, Nom = "Controleur de gestion", DebutValidite = DateTime.Parse("12/12/2015"), FinValidite = DateTime.Parse("12/12/2017"), CategorieId = 2 },
                new Metier { ID = 7, Nom = "Responsable RH", DebutValidite = DateTime.Parse("12/12/2015"), FinValidite = DateTime.Parse("12/12/2017"), CategorieId = 3 },
                new Metier { ID = 8, Nom = "Chargé(e) de recrutement", DebutValidite = DateTime.Parse("12/12/2015"), FinValidite = DateTime.Parse("12/12/2017"), CategorieId = 3 },
                new Metier { ID = 9, Nom = "Directeur conseil", DebutValidite = DateTime.Parse("12/12/2015"), FinValidite = DateTime.Parse("12/12/2017"), CategorieId = 4 },
                new Metier { ID = 10, Nom = "Directeur de développement", DebutValidite = DateTime.Parse("12/12/2015"), FinValidite = DateTime.Parse("12/12/2017"), CategorieId = 4 },
                new Metier { ID = 11, Nom = "Développeur", DebutValidite = DateTime.Parse("12/12/2015"), FinValidite = DateTime.Parse("12/12/2017"), CategorieId = 5 },
                new Metier { ID = 12, Nom = "Graphiste", DebutValidite = DateTime.Parse("12/12/2015"), FinValidite = DateTime.Parse("12/12/2017"), CategorieId = 5 },
                new Metier { ID = 13, Nom = "Chef de projet web", DebutValidite = DateTime.Parse("12/12/2015"), FinValidite = DateTime.Parse("12/12/2017"), CategorieId = 5 },
                new Metier { ID = 14, Nom = "Chef de projet digital", DebutValidite = DateTime.Parse("12/12/2015"), FinValidite = DateTime.Parse("12/12/2017"), CategorieId = 6 },
                new Metier { ID = 15, Nom = "Chef de projet event", DebutValidite = DateTime.Parse("12/12/2015"), FinValidite = DateTime.Parse("12/12/2017"), CategorieId = 6 },
                new Metier { ID = 16, Nom = "Chef de projet éditorial", DebutValidite = DateTime.Parse("12/12/2015"), FinValidite = DateTime.Parse("12/12/2017"), CategorieId = 6 }
            );

            context.Roles.AddOrUpdate(
              r => r.Nom,
              new Role { ID = 1, Nom = "Manager" },
              new Role { ID = 2, Nom = "Chef d'équipe" },
              new Role { ID = 3, Nom = "Responsable fonctionnel" },
              new Role { ID = 4, Nom = "Responsable technique" },
              new Role { ID = 5, Nom = "Apprenti" },
              new Role { ID = 6, Nom = "Organisateur" },
              new Role { ID = 7, Nom = "Coordinateur" },
              new Role { ID = 8, Nom = "Référent technique" },
              new Role { ID = 9, Nom = "Référent fonctionnel" }
          );
        }
    }
}
