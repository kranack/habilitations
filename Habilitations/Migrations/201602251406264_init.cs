namespace Habilitations.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class init : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Jobs", "DebutJob", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Jobs", "FinJob", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Jobs", "FinJob", c => c.DateTime());
            AlterColumn("dbo.Jobs", "DebutJob", c => c.DateTime());
        }
    }
}
