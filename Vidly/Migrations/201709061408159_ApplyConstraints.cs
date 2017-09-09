namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ApplyConstraints : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Movies", "Name", c => c.String(nullable: false, maxLength: 255));
            AlterColumn("dbo.Casts", "Actors", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Casts", "Actors", c => c.String());
            AlterColumn("dbo.Movies", "Name", c => c.String());
        }
    }
}
