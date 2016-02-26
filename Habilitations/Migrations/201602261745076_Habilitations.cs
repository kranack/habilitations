namespace Habilitations.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Habilitations : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Categories",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Nom = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Metiers",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Nom = c.String(nullable: false),
                        DebutValidite = c.DateTime(nullable: false),
                        FinValidite = c.DateTime(nullable: false),
                        CategorieId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Categories", t => t.CategorieId, cascadeDelete: true)
                .Index(t => t.CategorieId);
            
            CreateTable(
                "dbo.Jobs",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        DebutJob = c.DateTime(nullable: false),
                        FinJob = c.DateTime(nullable: false),
                        MetierId = c.Int(nullable: false),
                        UserId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Metiers", t => t.MetierId, cascadeDelete: true)
                .ForeignKey("dbo.Users", t => t.UserId, cascadeDelete: true)
                .Index(t => t.MetierId)
                .Index(t => t.UserId);
            
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
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Roles",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Nom = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.RoleUsers",
                c => new
                    {
                        Role_ID = c.Int(nullable: false),
                        User_ID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Role_ID, t.User_ID })
                .ForeignKey("dbo.Roles", t => t.Role_ID, cascadeDelete: true)
                .ForeignKey("dbo.Users", t => t.User_ID, cascadeDelete: true)
                .Index(t => t.Role_ID)
                .Index(t => t.User_ID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.RoleUsers", "User_ID", "dbo.Users");
            DropForeignKey("dbo.RoleUsers", "Role_ID", "dbo.Roles");
            DropForeignKey("dbo.Jobs", "UserId", "dbo.Users");
            DropForeignKey("dbo.Jobs", "MetierId", "dbo.Metiers");
            DropForeignKey("dbo.Metiers", "CategorieId", "dbo.Categories");
            DropIndex("dbo.RoleUsers", new[] { "User_ID" });
            DropIndex("dbo.RoleUsers", new[] { "Role_ID" });
            DropIndex("dbo.Jobs", new[] { "UserId" });
            DropIndex("dbo.Jobs", new[] { "MetierId" });
            DropIndex("dbo.Metiers", new[] { "CategorieId" });
            DropTable("dbo.RoleUsers");
            DropTable("dbo.Roles");
            DropTable("dbo.Users");
            DropTable("dbo.Jobs");
            DropTable("dbo.Metiers");
            DropTable("dbo.Categories");
        }
    }
}
