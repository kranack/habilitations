namespace Habilitations.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Matricule = c.String(),
                        Nom = c.String(nullable: false),
                        Prenom = c.String(nullable: false),
                        DateNaissance = c.DateTime(nullable: false),
                        DateEntree = c.DateTime(nullable: false),
                        JobId = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Jobs", t => t.JobId);
            
            CreateTable(
                "dbo.Jobs",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        DebutJob = c.DateTime(),
                        FinJob = c.DateTime(),
                        MetierId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Metiers", t => t.MetierId, cascadeDelete: true);
            
            CreateTable(
                "dbo.Metiers",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Nom = c.String(nullable: false),
                        CategorieId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Categories", t => t.CategorieId, cascadeDelete: true);
            
            CreateTable(
                "dbo.Categories",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Nom = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Metiers", "CategorieId", "dbo.Categories");
            DropForeignKey("dbo.Jobs", "MetierId", "dbo.Metiers");
            DropForeignKey("dbo.Users", "JobId", "dbo.Jobs");
            DropTable("dbo.Categories");
            DropTable("dbo.Metiers");
            DropTable("dbo.Jobs");
            DropTable("dbo.Users");
        }
    }
}
