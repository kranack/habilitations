namespace Habilitations.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Habilitations : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Users", "Metier_ID", "dbo.Metiers");
            DropIndex("dbo.Users", new[] { "Metier_ID" });
            DropColumn("dbo.Users", "Metier_ID");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Users", "Metier_ID", c => c.Int());
            CreateIndex("dbo.Users", "Metier_ID");
            AddForeignKey("dbo.Users", "Metier_ID", "dbo.Metiers", "ID");
        }
    }
}
